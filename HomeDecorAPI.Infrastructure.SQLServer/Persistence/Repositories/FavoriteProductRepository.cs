using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Persistence.Repositories
{
    public class FavoriteProductRepository : RepositoryBase<FavoriteProduct>, IFavoriteProductRepository
    {

        private readonly ApplicationDbContext _context;
        public FavoriteProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> IsProductInFavoritesAsync(string userId, int productId) {
            return await _context.FavoriteProducts
                .AnyAsync(fp => fp.UserId == userId && fp.ProductId == productId);
        }

        public async Task<List<FavoriteProduct>> GetFavoritesByUserIdAsync(string userId) {
            return await _context.FavoriteProducts
                .Where(fp => fp.UserId == userId)
                .Include(fp => fp.User)
                .ToListAsync();
        }
    }
}
