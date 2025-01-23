using System.ComponentModel.DataAnnotations;

namespace ManipulationImage.DTOs
{
    public class ProductDTO
    {
        [Required]
        [MaxLength(30)]
        public string? ProductName { get; set; }
        
        [Required]
        public IFormFile? ImageFile { get; set; }
    }
}