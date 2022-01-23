using CongestionTaxCalculator.Repository.Lookup;
using CongestionTaxCalculator.Repository.Models;
using CongestionTaxCalculator.Service.Configuration;
using CongestionTaxCalculator.Service.Dtos;
using Microsoft.Extensions.Options;

namespace CongestionTaxCalculator.Service.Service
{
    public class CalculatorService : ICalculatorService
    {
        private readonly ILookupRepository lookupService;
        private readonly IOptionsSnapshot<SingleChargeRuleConfiguration> singleChargeRuleConfiguration;
        private readonly IOptionsSnapshot<CongestionTaxRuleConfiguration> congestionTaxRuleConfiguration;

        public CalculatorService(
            ILookupRepository lookupService,
            IOptionsSnapshot<SingleChargeRuleConfiguration> singleChargeRuleConfiguration,
            IOptionsSnapshot<CongestionTaxRuleConfiguration> congestionTaxRuleConfiguration)
        {
            this.lookupService = lookupService ?? throw new ArgumentNullException(nameof(lookupService));
            this.singleChargeRuleConfiguration = singleChargeRuleConfiguration ?? throw new ArgumentNullException(nameof(singleChargeRuleConfiguration));
            this.congestionTaxRuleConfiguration = congestionTaxRuleConfiguration ?? throw new ArgumentNullException(nameof(congestionTaxRuleConfiguration));
        }

        public async Task<int> GetTaxAsync(CongestionTaxVehicleDto congestionTaxVehicleDto, CancellationToken cancellationToken = default)
        {
            if (congestionTaxVehicleDto == null) 
            {
                throw new AggregateException(nameof(CongestionTaxVehicleDto));
            }

            if (congestionTaxVehicleDto.Vehicle == null)
            {
                throw new AggregateException(nameof(congestionTaxVehicleDto.Vehicle));
            }

            if (congestionTaxVehicleDto.Dates == null || !congestionTaxVehicleDto.Dates.Any())
            {
                throw new AggregateException(nameof(congestionTaxVehicleDto.Dates));
            }

            VehicleDto vehicleDto = congestionTaxVehicleDto.Vehicle;

            if (await this.IsTollFreeVehicleAsync(vehicleDto, cancellationToken))
            {
                return 0;
            }

            List<DateTime> sortedDates = congestionTaxVehicleDto.Dates.OrderBy(x => x).ToList();

            DateTime intervalStart = sortedDates[0];
            int tempFee = await this.GetTollFeeAsync(intervalStart, cancellationToken);
            int pointer = 1;
            int totalFee = 0;
            while (pointer < sortedDates.Count)
            {
                DateTime date = sortedDates[pointer];
                int nextFee = await this.GetTollFeeAsync(date, cancellationToken);

                if (this.singleChargeRuleConfiguration.Value.IsEnabled)
                {
                    TimeSpan timeSpan = date.Subtract(intervalStart);

                    if (timeSpan.TotalMinutes <= this.singleChargeRuleConfiguration.Value.Minutes)
                    {
                        if (nextFee >= tempFee)
                        {
                            tempFee = nextFee;
                        }
                    }
                    else
                    {
                        totalFee += tempFee;
                        tempFee = nextFee;
                        if (sortedDates.Count > pointer + 1)
                        {
                            intervalStart = sortedDates[pointer + 1];
                        }
                    }
                }
                else
                {
                    totalFee += nextFee;
                }

                pointer++;
            }

            totalFee += tempFee;

            if (this.congestionTaxRuleConfiguration.Value.IsEnabled && totalFee > this.congestionTaxRuleConfiguration.Value.MaxAmount)
            {
                totalFee = this.congestionTaxRuleConfiguration.Value.MaxAmount;
            }

            return totalFee;
        }

        private async Task<bool> IsTollFreeVehicleAsync(VehicleDto VehicleDto, CancellationToken cancellationToken)
        {
            if (VehicleDto == null)
            {
                throw new ArgumentNullException(nameof(VehicleDto));
            }

            List<TaxExemptVehicle> exemptVehicles = await this.lookupService.GetTaxExemptVehiclesAsync(cancellationToken);

            string vehicleType = VehicleDto.VehicleCode;

            return exemptVehicles.Any(v => string.Equals(vehicleType, v.VehicleCode, StringComparison.InvariantCulture));
        }

        public async Task<int> GetTollFeeAsync(DateTime date, CancellationToken cancellationToken)
        {
            if (await this.IsTollFreeDate(date, cancellationToken))
            {
                return 0;
            }

            int hour = date.Hour;
            int minute = date.Minute;

            TimeSpan timeSpan = new TimeSpan(date.Hour, date.Minute, 0);

            List<CongestionTax> congetionTaxes = await this.lookupService.GetCongestionTaxesAsync(cancellationToken);

            return congetionTaxes.First(t => t.StartTime <= timeSpan && t.EndTime >= timeSpan).Amount;
        }

        private async Task<bool> IsTollFreeDate(DateTime date, CancellationToken cancellationToken)
        {
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

            List<TaxExceptDate> exceptDates = await this.lookupService.GetTaxExceptDatesAsync(cancellationToken);

            return exceptDates.Any(d => d.Date.Year == year && d.Date.Month == month && date.Day == day);
        }
    }
}
