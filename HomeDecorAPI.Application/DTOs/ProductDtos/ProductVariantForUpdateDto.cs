using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.ProductDtos
{
    public class ProductVariantForUpdateDto
    {
        [Required]
        [StringLength(50)]
        public required string Color { get; set; }

        [StringLength(50)]
        public string? SKU { get; set; }
        public bool IsMainVariant { get; set; } = false;

        // Giá và khuyến mãi
        [Required]
        [Range(0, double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }

        [Range(0, 100)]
        public int? DiscountPercentage { get; set; }
        public DateTime? DiscountStartDate { get; set; }
        public DateTime? DiscountEndDate { get; set; }

        // Kho hàng
        [Required]
        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }
        public DateTime? IsNewStartDate { get; set; }
        public DateTime? IsNewEndDate { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<ProductImageForCreateDto>? Images { get; set; }
    }
}
