using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.CartDtos {
    public class CartItemForAddToCartDto {
        [Required(ErrorMessage = "ProductId is required.")]
        public required string UserId { get; set; }

        [Required(ErrorMessage = "ProductId is required.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; } = 1;
    }
}
