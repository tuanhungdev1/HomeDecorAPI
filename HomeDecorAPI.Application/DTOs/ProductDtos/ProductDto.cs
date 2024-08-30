using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.ProductDtos {
    public class ProductDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal OriginalPrice { get; set; }
        public int? DiscountPercentage { get; set; }
        public decimal? DiscountedPrice {
            get {
                if (DiscountPercentage.HasValue) {
                    return OriginalPrice - (OriginalPrice * DiscountPercentage.Value / 100);
                }
                return null;
            }

        }
        public string ImageUrl { get; set; }

        public string SKU { get; set; }

        public string Measurements { get; set; }

        public int StockQuantity { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? DiscountEndDate { get; set; }

        public DateTime? IsNewExpiryDate { get; set; }

        public bool IsDiscountActive {
            get {
                return DiscountPercentage.HasValue && DiscountEndDate.HasValue && DiscountEndDate > DateTime.UtcNow;
            }
        }

        public bool IsStillNew {
            get {
                return IsNewExpiryDate.HasValue && IsNewExpiryDate > DateTime.UtcNow;
            }
        }
    }
}
