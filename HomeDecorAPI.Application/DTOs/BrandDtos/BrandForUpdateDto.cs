using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.BrandDtos
{
    public class BrandForUpdateDto
    {
        [Required(ErrorMessage = "Tên Brand không được để trống.")]
        [StringLength(100, ErrorMessage = "Độ dài tối đa trong khoảng 100 kí tự.")]
        public required string Name { get; set; }
        [StringLength(300, ErrorMessage = "Độ dài tối đa trong khoảng 300 kí tự.")]
        public string? Description { get; set; }
        public IFormFile? LogoFile { get; set; }
        public bool? IsActive { get; set; }
    }
}
