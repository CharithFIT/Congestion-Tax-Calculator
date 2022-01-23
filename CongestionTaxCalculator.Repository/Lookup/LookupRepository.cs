using CongestionTaxCalculator.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace CongestionTaxCalculator.Repository.Lookup
{
    public class LookupRepository : ILookupRepository
    {
        private readonly CongestionTaxCalculatorDbContext congestionTaxCalculatorDbContext;
        private readonly IMemoryCache memoryCache;

        public LookupRepository(CongestionTaxCalculatorDbContext congestionTaxCalculatorDbContext, IMemoryCache memoryCache)
        {
            this.congestionTaxCalculatorDbContext = congestionTaxCalculatorDbContext ??
                throw new ArgumentNullException(nameof(congestionTaxCalculatorDbContext));
            this.memoryCache = memoryCache ?? throw new ArgumentNullException(nameof(memoryCache));
        }

        public async Task<List<CongestionTax>> GetCongestionTaxesAsync(CancellationToken cancellationToken = default)
        {
            const string cacheKey = "CongestionTaxList";
            List<CongestionTax> congestionTaxes = await this.GetCachedValue<CongestionTax>(cacheKey,
                () => this.congestionTaxCalculatorDbContext.CongestionTaxes.ToListAsync(cancellationToken));

            return congestionTaxes;
        }

        public async Task<List<TaxExceptDate>> GetTaxExceptDatesAsync(CancellationToken cancellationToken = default)
        {
            const string cacheKey = "TaxExceptDateList";
            List<TaxExceptDate> taxExceptDates = await this.GetCachedValue<TaxExceptDate>(cacheKey,
                () => this.congestionTaxCalculatorDbContext.TaxExceptDates.ToListAsync(cancellationToken));

            return taxExceptDates;
        }

        public async Task<List<TaxExemptVehicle>> GetTaxExemptVehiclesAsync(CancellationToken cancellationToken = default)
        {
            const string cacheKey = "TaxExemptVehicleList";
            List<TaxExemptVehicle> taxExemptVehicles = await this.GetCachedValue<TaxExemptVehicle>(cacheKey,
                () => this.congestionTaxCalculatorDbContext.TaxExemptVehicles.ToListAsync(cancellationToken));

            return taxExemptVehicles;
        }

        private async Task<List<T>> GetCachedValue<T>(string cacheKey, Func<Task<List<T>>> readFromDbFunc)
        {
            List<T> list;

            if (!this.memoryCache.TryGetValue(cacheKey, out list))
            {
                list = await readFromDbFunc();

                memoryCache.Set(cacheKey, list);
            }

            return list;
        }
    }
}
