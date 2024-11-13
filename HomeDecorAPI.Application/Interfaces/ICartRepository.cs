using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Application.DTOs.CartDtos;
using HomeDecorAPI.Domain.Common.enums;
using HomeDecorAPI.Domain.Entities;

namespace HomeDecorAPI.Application.Interfaces {

    public interface ICartRepository : IRepositoryBase<Cart> {
		//Task<Cart?> GetCartByIdAsync(int cartId, bool includeItems = true);
		//Task<Cart?> GetActiveCartByUserIdAsync(int userId);
		//Task<IEnumerable<Cart>> GetCartsByUserIdAsync(int userId);
		//Task<IEnumerable<Cart>> GetCartsByStatusAsync(CartStatus status);
		//Task<Cart> CreateCartAsync(int userId);

		//Task<Cart> AddItemToCartAsync(int cartId, AddCartItemDto itemDto);
		//Task<Cart> UpdateCartItemQuantityAsync(int cartId, int productVariantId, int quantity);
		//Task<Cart> RemoveItemFromCartAsync(int cartId, int productVariantId);
		//Task<Cart> ClearCartAsync(int cartId);
		//Task<Cart> UpdateItemsSelectionAsync(int cartId, int[] selectedItemIds);

		//Task<Cart> UpdateCartStatusAsync(int cartId, CartStatus status);
		//Task<Cart> RecalculateCartAsync(int cartId);
		//Task<Cart> ApplyCouponAsync(int cartId, string couponCode);
		//Task<Cart> RemoveCouponAsync(int cartId);
		//Task<Cart> UpdateShippingFeeAsync(int cartId, decimal shippingFee);

		// Queries
		//Task<bool> IsCartExistsAsync(int cartId);
		//Task<bool> IsProductInCartAsync(int cartId, int productVariantId);
		//Task<int> GetCartItemsCountAsync(int cartId);
		//Task<IEnumerable<Cart>> GetExpiredCartsAsync();
	}
}
