using System;
using System.ComponentModel.DataAnnotations;

namespace HomeDecorAPI.Domain.Entities {
    public class CartItem {
        public int Id { get; set; }

        [Required(ErrorMessage = "CartId is required.")]
        public int CartId { get; set; }

        [Required(ErrorMessage = "Product is required.")]
        public required Cart Cart { get; set; }

        [Required(ErrorMessage = "ProductId is required.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product is required.")]
        public required Product Product { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
        public int Quantity { get; set; } = 1;

        [Range(0.01, double.MaxValue, ErrorMessage = "UnitPrice must be greater than zero.")]
        public decimal UnitPrice {
            get {
                if (Product.DiscountPercentage.HasValue) {
                    return Product.OriginalPrice - (Product.OriginalPrice * Product.DiscountPercentage.Value / 100);
                }
                return Product.OriginalPrice;
            }
         }

        [Range(0.01, double.MaxValue, ErrorMessage = "TotalPrice must be greater than zero.")]
        public decimal TotalPrice => Quantity * UnitPrice;

        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters.")]
        public string SKU { 
            get {
                return Product?.SKU ?? string.Empty;
            }
        }

        [StringLength(20, ErrorMessage = "Color cannot exceed 20 characters.")]
        public string Color { get; set; }

        [StringLength(20, ErrorMessage = "Size cannot exceed 20 characters.")]
        public required string Size { get; set; }

        [Required(ErrorMessage = "AddedAt is required.")]
        public DateTime AddedAt { get; set; }

        [Required(ErrorMessage = "UpdatedAt is required.")]
        public DateTime UpdatedAt { get; set; }

        [Range(0.00, double.MaxValue, ErrorMessage = "ItemDiscount cannot be negative.")]
        public decimal ItemDiscount { get; set; }
    }
}
