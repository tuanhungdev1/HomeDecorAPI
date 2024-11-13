using HomeDecorAPI.Domain.Common.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HomeDecorAPI.Domain.Entities
{
	public class Cart : BaseEntity
	{
		[Column(TypeName = "decimal(18,2)")]
		public decimal ShippingFee { get; set; } = 0;
		[Column(TypeName = "decimal(18,2)")]
		public decimal Tax { get; set; }
		[NotMapped]
		public decimal SubTotal => CalculateSubTotal();
		[Column(TypeName = "decimal(18,2)")]
		public decimal Discount { get; set; }
		[NotMapped]
		public decimal GrandTotal => CalculateGrandTotal();
		public string? CouponCode { get; set; }
		public DateTime ExpiryDate { get; set; }
		public CartStatus Status { get; set; } = CartStatus.Active;
		public string UserId { get; set; }
		public User User { get; set; }
		public ICollection<CartItem>? CartItems { get; set; }
        public int? AppliedDiscountId { get; set; }
        public int? AppliedCouponId { get; set; }
        public Discount? AppliedDiscount { get; set; }
		public Coupon? AppliedCoupon { get; set; }
		private decimal CalculateSubTotal()
		{
			return CartItems?.Sum(item => item.Total) ?? 0;
		}
		private decimal CalculateGrandTotal()
		{
			var totalBeforeDiscount = SubTotal + Tax + ShippingFee;
			return totalBeforeDiscount - Discount;
		}
		public void ApplyDiscount(decimal discount)
		{
			Discount = discount;
		}
		public void ApplyCoupon(string couponCode, decimal discountAmount)
		{
			CouponCode = couponCode;
			Discount = discountAmount;
		}
	}
}
