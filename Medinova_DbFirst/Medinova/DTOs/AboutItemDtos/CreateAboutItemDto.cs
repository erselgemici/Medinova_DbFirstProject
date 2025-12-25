using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medinova.DTOs.AboutItemDtos
{
    public class CreateAboutItemDto
    {
        [Required(ErrorMessage = "Özellik adı (Örn: 7/24 Hizmet) zorunludur.")]
        public string Name { get; set; }

        public string Icon { get; set; }
    }
}
