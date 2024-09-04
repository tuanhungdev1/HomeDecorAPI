using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace HomeDecorAPI.Infrastructure.SQLServer.Repositories {
    internal class CartRepository : RepositoryBase<Cart>, ICartRepository {
        public CartRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            
        }

        public async Task<IEnumerable<CartItem>> GetAllCartItemForUserAsync(string userId) {
            var cart = await FindByCondition(c => c.UserId == userId)
                                .Include(c => c.Items)
                                .SingleOrDefaultAsync();

            return cart?.Items ?? new List<CartItem>();
        }

        public async Task<bool> IsProductInCartAsync(string userId, int productId) {
            var items = await GetAllCartItemForUserAsync(userId);
            if(items.Count() == 0)
                return false;

            var product = items.Where(ci => ci.ProductId == productId).FirstOrDefault();

            if(product == null) return false;

            return true;
        }
    }
}
