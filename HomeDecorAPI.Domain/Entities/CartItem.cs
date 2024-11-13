using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeDecorAPI.Domain.Entities
{
	public class CartItem : BaseEntity
	{
		public int CartId { get; set; }
		public int ProductVariantId { get; set; }
		[Required]
		[Range(1, int.MaxValue)]
		public int Quantity { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal UnitPrice { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal? DiscountedUnitPrice { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal SubTotal => CalculateSubTotal();

		[Column(TypeName = "decimal(18,2)")]
		public decimal Total => CalculateTotal();
		public bool IsSelected { get; set; } = false;
		public Cart Cart { get; set; }
		public ProductVariant ProductVariant { get; set; }
		private decimal CalculateSubTotal()
		{
			return UnitPrice * Quantity;
		}

		
		private decimal CalculateTotal()
		{
		
			decimal effectiveUnitPrice = DiscountedUnitPrice ?? UnitPrice;
			return effectiveUnitPrice * Quantity;
		}

		public void UpdateQuantity(int quantity)
		{
			Quantity = quantity;
		}

		public void ApplyDiscount(decimal discountedPrice)
		{
			DiscountedUnitPrice = discountedPrice;
		}
	}
}
