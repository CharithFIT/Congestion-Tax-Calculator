using CongestionTaxCalculator.Repository.Models;

namespace CongestionTaxCalculator.Repository.Lookup
{
    public interface ILookupRepository
    {
        Task<List<CongestionTax>> GetCongestionTaxesAsync(CancellationToken cancellationToken = default);

        Task<List<TaxExceptDate>> GetTaxExceptDatesAsync(CancellationToken cancellationToken = default);

        Task<List<TaxExemptVehicle>>  GetTaxExemptVehiclesAsync(CancellationToken cancellationToken = default);
    }
}
