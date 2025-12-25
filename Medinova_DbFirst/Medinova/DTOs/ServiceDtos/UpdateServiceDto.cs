using System.ComponentModel.DataAnnotations;

namespace Medinova.DTOs.ServiceDtos
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı zorunludur.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama zorunludur.")]
        public string Description { get; set; }

        public string Icon { get; set; }
    }
}
