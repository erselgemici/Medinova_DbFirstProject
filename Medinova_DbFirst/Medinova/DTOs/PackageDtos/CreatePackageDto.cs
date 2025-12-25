using System.ComponentModel.DataAnnotations;

namespace Medinova.DTOs.PackageDtos
{
    public class CreatePackageDto
    {
        [Required(ErrorMessage = "Paket adı (Örn: Standart) zorunludur.")]
        public string PackageName { get; set; }

        [Required(ErrorMessage = "Fiyat bilgisi zorunludur.")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Süre (Ay/Yıl) zorunludur.")]
        public string Period { get; set; }

        // Özellikler boş geçilebilir olabilir, opsiyonel bırakıyorum
        public string Feature1 { get; set; }
        public string Feature2 { get; set; }
        public string Feature3 { get; set; }
        public string Feature4 { get; set; }
    }
}
