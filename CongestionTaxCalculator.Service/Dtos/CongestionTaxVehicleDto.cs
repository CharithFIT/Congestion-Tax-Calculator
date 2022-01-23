namespace CongestionTaxCalculator.Service.Dtos
{
    public class CongestionTaxVehicleDto
    {
        public VehicleDto Vehicle { get; set; }

        public DateTime[] Dates { get; set; }
    }
}
