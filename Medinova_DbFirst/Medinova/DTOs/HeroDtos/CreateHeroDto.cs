using System.ComponentModel.DataAnnotations;

namespace Medinova.DTOs.HeroDtos
{
    public class CreateHeroDto
    {
        [Required(ErrorMessage = "Başlık zorunludur.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama zorunludur.")]
        public string Description { get; set; }
    }
}
