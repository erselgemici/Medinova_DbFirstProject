using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medinova.DTOs.AboutItemDtos
{
    public class UpdateAboutItemDto
    {
        public int AboutItemId { get; set; }

        [Required(ErrorMessage = "Özellik adı zorunludur.")]
        public string Name { get; set; }

        public string Icon { get; set; }
    }
}
