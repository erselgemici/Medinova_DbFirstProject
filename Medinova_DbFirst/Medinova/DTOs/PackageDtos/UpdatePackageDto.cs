using System.ComponentModel.DataAnnotations;

namespace Medinova.DTOs.PackageDtos
{
    public class UpdatePackageDto
    {
        public int PackageID { get; set; }

        [Required(ErrorMessage = "Paket adı zorunludur.")]
        public string PackageName { get; set; }

        [Required(ErrorMessage = "Fiyat bilgisi zorunludur.")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Süre bilgisi zorunludur.")]
        public string Period { get; set; }

        public string Feature1 { get; set; }
        public string Feature2 { get; set; }
        public string Feature3 { get; set; }
        public string Feature4 { get; set; }
    }
}
