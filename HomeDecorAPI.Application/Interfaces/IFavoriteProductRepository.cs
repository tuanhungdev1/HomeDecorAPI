using HomeDecorAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Interfaces {
    public interface IFavoriteProductRepository : IRepositoryBase<FavoriteProduct>  {
        Task<bool> IsProductInFavoritesAsync(string userId, int productId);
        Task<List<FavoriteProduct>> GetFavoritesByUserIdAsync(string userId);
    }
}
