using HomeDecorAPI.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace HomeDecorAPI.Application.DTOs.CartDtos {
    public class CartItemDto {
        public int Id { get; set; }

        [Required(ErrorMessage = "CartId is required.")]
        public int CartId { get; set; }

        [Required(ErrorMessage = "Product is required.")]
        public Cart? Cart { get; set; }

        [Required(ErrorMessage = "ProductId is required.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product is required.")]
        public Product? Product { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
        public int Quantity { get; set; } = 1;

        [Range(0.01, double.MaxValue, ErrorMessage = "UnitPrice must be greater than zero.")]

        [Required(ErrorMessage = "AddedAt is required.")]
        public DateTime? AddedAt { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "UpdatedAt is required.")]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
