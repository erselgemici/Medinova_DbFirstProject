using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medinova.DTOs.ServiceDtos
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet başlığı zorunludur.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama zorunludur.")]
        public string Description { get; set; }

        public string Icon { get; set; }
    }
}
