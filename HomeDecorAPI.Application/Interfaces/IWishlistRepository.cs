using HomeDecorAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Application.Shared.RequestFeatures;

namespace HomeDecorAPI.Application.Interfaces {
    public interface IWishlistRepository : IRepositoryBase<WishlistItem>  {
        Task<PagedList<WishlistItem>> GetUserWishlistAsync(string userId, WishlistRequestParameters parameters);
        Task<WishlistItem> GetAsync(string userId, int productId);
        Task<IEnumerable<WishlistItem>> GetAllAsync(string userId);
        Task AddAsync(WishlistItem wishlistItem);
        Task RemoveAsync(WishlistItem wishlistItem);
        Task ClearAsync(string userId);
        Task<bool> ExistsAsync(string userId, int productId);

	}
}
