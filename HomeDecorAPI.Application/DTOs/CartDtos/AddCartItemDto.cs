using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.CartDtos {
    public class AddCartItemDto
	{
		[Required]
		public int CartId { get; set; }
		[Required]
		public int ProductVariantId { get; set; }
		[Required]
		[Range(1, int.MaxValue)]
		public int Quantity { get; set; }
		[Required]
		public decimal UnitPrice { get; set; }
		public decimal? DiscountedUnitPrice { get; set; }
	}
}
