using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.DTOs.WishlistDtos;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
	public interface IWishlistService
	{
		Task<(IEnumerable<WishlistItemDto> Items, MetaData MetaData)> GetUserWishlistAsync(string userId, WishlistRequestParameters parameters);
		Task<WishlistItemDto> AddToWishlistAsync(string userId, int productId);
		Task RemoveFromWishlistAsync(string userId, int productId);
		Task<bool> CheckInWishlistAsync(string userId, int productId);
		Task MoveAllToCartAsync(string userId);
		Task ClearWishlistAsync(string userId);
	}
}
