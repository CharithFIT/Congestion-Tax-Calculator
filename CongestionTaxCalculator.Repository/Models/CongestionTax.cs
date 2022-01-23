using System.ComponentModel.DataAnnotations;

namespace CongestionTaxCalculator.Repository.Models
{
    public class CongestionTax
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}
