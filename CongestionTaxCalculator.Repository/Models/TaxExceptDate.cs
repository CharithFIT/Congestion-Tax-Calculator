using System.ComponentModel.DataAnnotations;

namespace CongestionTaxCalculator.Repository.Models
{
    public class TaxExceptDate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
