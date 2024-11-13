using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeDecorAPI.Domain.Entities {
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
		public decimal? DiscountedPrice { get; set; }

		public Cart Cart { get; set; }
		public ProductVariant ProductVariant { get; set; }
	}
}