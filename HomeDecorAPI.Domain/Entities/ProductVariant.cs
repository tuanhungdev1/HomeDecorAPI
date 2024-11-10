using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Domain.Common.enums;

namespace HomeDecorAPI.Domain.Entities
{
    public class ProductVariant : BaseEntity
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public required string Color { get; set; }

        [Required]
        [StringLength(50)]
        public required string SKU { get; set; }
        public bool IsMainVariant { get; set; } = false;

        // Giá và khuyến mãi
        [Required]
        [Range(0, double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }

        [Range(0, 100)]
        public int? DiscountPercentage { get; set; }
        [NotMapped]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountPrice
        {
            get
            {
                if (DiscountPercentage.HasValue && DiscountPercentage > 0)
                {
                    return OriginalPrice - (OriginalPrice * (DiscountPercentage.Value / 100));
                }
                return OriginalPrice; 
            }
        }

        public DateTime? DiscountStartDate { get; set; }

        public DateTime? DiscountEndDate { get; set; }

        // Kho hàng
        [Required]
        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; } = true;
        public StockStatus StockStatus
        {
            get
            {
                if (!IsActive) return StockStatus.Discontinued;
                if (StockQuantity <= 0) return StockStatus.OutOfStock;
                if (StockQuantity <= 10) return StockStatus.LowStock;
                return StockStatus.InStock;
            }
        }
        public Product? Product { get; set; }
        public ICollection<ProductImage>? Images { get; set; }
    }
}
