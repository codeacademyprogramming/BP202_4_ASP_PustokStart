using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class PortfolioImage
    {
        public int Id { get; set; }

        [Required]
        public int PortfolioId { get; set;}

        [Required]
        [StringLength(maximumLength:100)]
        public string Name { get; set; }

        [Required]
        public bool IsPoster { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
