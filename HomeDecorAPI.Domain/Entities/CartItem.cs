using System;
using System.ComponentModel.DataAnnotations;

namespace HomeDecorAPI.Domain.Entities {
    public class CartItem {
        public int Id { get; set; }

        [Required(ErrorMessage = "CartId is required.")]
        public int CartId { get; set; }

        public virtual Cart? Cart { get; set; }

        [Required(ErrorMessage = "ProductId is required.")]
        public int ProductId { get; set; }

        public virtual Product? Product { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
        public int Quantity { get; set; } = 1;
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}