using HomeDecorAPI.Domain.Common.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.ProductDtos {
    public class ProductForCreateDto {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "Description cannot exceed 300 characters.")]
        public string ShortDescription { get; set; }
        public DateTime? IsNewStartDate { get; set; }
        public DateTime? IsNewEndDate { get; set; }
        [Required]
        public ProductStatus Status { get; set; } = ProductStatus.Draft;
        [Required]
        public bool IsPublished { get; set; } = false;
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z0-9]+$")]
        public string BaseSKU { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Measurements cannot exceed 100 characters.")]
        public string Measurements { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public int? SupplierId { get; set; }
        public ProductDetailsForCreateDto? Details { get; set; }
        public ICollection<ProductVariantForCreateDto> Variants { get; set; }
    }
}
