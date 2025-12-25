using System.ComponentModel.DataAnnotations;

namespace Medinova.DTOs.AboutDtos
{
    public class UpdateAboutDto
    {
        public int AboutId { get; set; }

        [Required(ErrorMessage = "Başlık zorunludur.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama zorunludur.")]
        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
