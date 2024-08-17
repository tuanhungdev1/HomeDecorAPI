using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.UploadDtos
{
    public class UploadAvatarDto
    {
        [Required]
        public IFormFile File { get; set; }
    }
}
