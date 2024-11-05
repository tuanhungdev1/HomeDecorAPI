using HomeDecorAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.ProductDtos
{
    public class ProductImageDto
    {
        public int Id { get; set; }
        public int? ProductVariantId { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsMainImage { get; set; } = true;
    }
}
