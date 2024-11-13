using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.WishlistDtos
{
	public class AddToWishlistDto
	{
		[Required]
		public int ProductVariantId { get; set; }
	}
}
