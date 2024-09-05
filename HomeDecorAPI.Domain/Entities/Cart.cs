using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace HomeDecorAPI.Domain.Entities {
    public class Cart {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "UserId is required.")]
        public required string UserId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Subtotal must be a positive number.")]
        public decimal Subtotal { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Shipping cost must be a positive number.")]
        public decimal ShippingCost { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Discount must be a positive number.")]
        public decimal Discount { get; set; }

        public decimal TotalPrice {
            get {
                // Calculate TotalPrice based on Items
                return Items?.Sum(x => x.TotalPrice) ?? 0;
            }
            set { }
        }

        [Required]
        [StringLength(50, ErrorMessage = "Status length can't be more than 50.")]
        public string Status { get; set; } = "Active";

        // Allow Items to be null or empty
        public ICollection<CartItem>? Items { get; set; } = new List<CartItem>();

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
    }
}
