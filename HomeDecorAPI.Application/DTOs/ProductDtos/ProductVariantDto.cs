using HomeDecorAPI.Domain.Common.enums;
using HomeDecorAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.ProductDtos
{
    public class ProductVariantDto
    {
        public int ProductId { get; set; }
        public required string Color { get; set; }
        public required string SKU { get; set; }
        public bool IsMainVariant { get; set; } = false;
        public decimal OriginalPrice { get; set; }
        public int? DiscountPercentage { get; set; }
        public decimal DiscountPrice
        {
            get
            {
                if (DiscountPercentage.HasValue && DiscountPercentage > 0)
                {
                    return OriginalPrice - (OriginalPrice * (DiscountPercentage.Value / 100));
                }
                return OriginalPrice; // Trả về giá gốc nếu không có giảm giá
            }
        }

        public DateTime? DiscountStartDate { get; set; }
        public DateTime? DiscountEndDate { get; set; }
        public int StockQuantity { get; set; }
        public DateTime? IsNewStartDate { get; set; }
        public DateTime? IsNewEndDate { get; set; }
        public bool IsCurrentlyNew
        {
            get
            {
                if (IsNewStartDate.HasValue && IsNewEndDate.HasValue)
                {
                    return DateTime.UtcNow >= IsNewStartDate.Value && DateTime.UtcNow <= IsNewEndDate.Value;
                }
                return false;
            }
        }
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
        public ICollection<ProductImageDto>? ProductImages { get; set; }
    }
}
