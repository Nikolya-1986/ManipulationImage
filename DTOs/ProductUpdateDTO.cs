using System.ComponentModel.DataAnnotations;

namespace ManipulationImage.DTOs
{
    public class ProductUpdateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string? ProductName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? ProductImage { get; set; }

        public IFormFile? ImageFile { get; set; }  
    }
}