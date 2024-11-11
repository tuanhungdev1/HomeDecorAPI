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
        public int Id { get; set; }
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
                    return OriginalPrice - (OriginalPrice * (DiscountPercentage.Value / 100m));
                }
                return OriginalPrice; 
            }
        }

        public DateTime? DiscountStartDate { get; set; }
        public DateTime? DiscountEndDate { get; set; }
        public int StockQuantity { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public bool IsNew
        {
            get
            {
                if (CreatedAt.HasValue)
                {
                    return (DateTime.UtcNow - CreatedAt.Value).TotalDays <= 7;
                }
                return false;
            }
        }

        public bool IsActive { get; set; } = true;
        public string StockStatusProduct
        {
            get
            {
                StockStatus status;

                if (!IsActive)
                    status = StockStatus.Discontinued;
                else if (StockQuantity <= 0)
                    status = StockStatus.OutOfStock;
                else if (StockQuantity <= 10)
                    status = StockStatus.LowStock;
                else
                    status = StockStatus.InStock;

                return status.ToString(); 
            }
        }

        public ICollection<ProductImageDto>? Images { get; set; }
    }
}
