using System.ComponentModel.DataAnnotations;

namespace CongestionTaxCalculator.Repository.Models
{
    public class TaxExemptVehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string VehicleCode { get; set; }

        [Required]
        public string VehicleName { get; set; }
    }
}
