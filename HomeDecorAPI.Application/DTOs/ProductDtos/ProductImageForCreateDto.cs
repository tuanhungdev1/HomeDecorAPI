using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.ProductDtos
{
    public class ProductImageForCreateDto
    {
        [Required]
        public IFormFile? ImageUrl { get; set; }
        public bool IsMainImage { get; set; } = true;
    }
}
