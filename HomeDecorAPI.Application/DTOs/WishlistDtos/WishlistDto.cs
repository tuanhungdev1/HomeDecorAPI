using HomeDecorAPI.Application.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.WishlistDtos
{
	public class WishlistItemDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
        public ProductVariantDto ProductVariantDto { get; set; }
        public DateTime AddedAt { get; set; }
	}
}
