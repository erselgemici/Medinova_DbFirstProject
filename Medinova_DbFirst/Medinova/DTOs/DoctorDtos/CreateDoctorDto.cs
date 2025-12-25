using System.ComponentModel.DataAnnotations;

namespace Medinova.DTOs.DoctorDtos
{
    public class CreateDoctorDto
    {
        [Required(ErrorMessage = "Doktor adı soyadı zorunludur.")]
        public string FullName { get; set; }

        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen bir bölüm seçiniz.")]
        public int DepartmentId { get; set; }

        public string Description { get; set; }
    }
}
