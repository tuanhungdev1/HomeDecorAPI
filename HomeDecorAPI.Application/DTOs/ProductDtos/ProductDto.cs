using HomeDecorAPI.Domain.Common.enums;
using HomeDecorAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.ProductDtos {
    public class ProductDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? BaseSKU { get; set; }
        public string? Measurements { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ProductStatus Status { get; set; } = ProductStatus.Draft;
        public bool IsPublished { get; set; } = false;
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int SupplierId { get; set; }
        public ProductDetailsDto? ProductDetails { get; set; }
        public ICollection<ProductVariantDto>? ProductVariants { get; set; }
    }
}
