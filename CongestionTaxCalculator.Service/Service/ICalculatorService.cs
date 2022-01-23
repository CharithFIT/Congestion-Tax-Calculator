using CongestionTaxCalculator.Service.Dtos;

namespace CongestionTaxCalculator.Service.Service
{
    public interface ICalculatorService
    {
        Task<int> GetTaxAsync(CongestionTaxVehicleDto congestionTaxVehicleDto, CancellationToken cancellationToken = default);
    }
}
