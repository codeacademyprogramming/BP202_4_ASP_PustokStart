using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Service
    {
        public int Id { get; set; } 
      
        [Required]
        [StringLength(maximumLength:50)]
        public string Title { get; set; }
        
        [StringLength(maximumLength: 250)]
        public string Desc { get; set; }
       
        [StringLength(maximumLength: 100)]
        public string Icon { get; set; }
    }
}
