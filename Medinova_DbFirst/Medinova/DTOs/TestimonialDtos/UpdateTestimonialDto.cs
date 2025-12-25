using System.ComponentModel.DataAnnotations;

namespace Medinova.DTOs.TestimonialDtos
{
    public class UpdateTestimonialDto
    {
        public int TestimonialID { get; set; }

        [Required(ErrorMessage = "Ad Soyad zorunludur.")]
        public string Name { get; set; }

        public string Profession { get; set; }

        [Required(ErrorMessage = "Yorum metni zorunludur.")]
        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
