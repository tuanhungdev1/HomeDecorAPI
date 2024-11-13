using HomeDecorAPI.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace HomeDecorAPI.Application.DTOs.CartDtos {
    public class CartDto {
		public int Id { get; set; }
		public string? CouponCode { get; set; }
		public decimal SubTotal { get; set; }
		public decimal DiscountAmount { get; set; }
		public decimal TotalAmount { get; set; }
		public ICollection<CartItemDto> Items { get; set; }
	}
}
