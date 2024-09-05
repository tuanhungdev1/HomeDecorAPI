using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using HomeDecorAPI.Application.DTOs.CartDtos;
using Microsoft.Identity.Client;

namespace HomeDecorAPI.Infrastructure.SQLServer.Repositories {
    internal class CartRepository : RepositoryBase<Cart>, ICartRepository {
        public CartRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            
        }

        public async Task<Cart> GetCartByUserIdAsync(string userId) {
            var cart = await _context.Carts
                .Include(c => c.Items)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            return cart!;
        }

        public async Task<IEnumerable<CartItem>> GetAllCartItemForUserAsync(string userId) {
            var cart = await _context.Carts
                .Include(c => c.Items)
                .FirstOrDefaultAsync();
            return cart?.Items ?? new List<CartItem>();
        }

        public async Task AddProductToCartAsync(string userId, int productId, CartItem cartItem) {
            var cart = await _context.Carts
                .Include(c => c.Items)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if(cart == null) {
                cart = new Cart {
                    UserId = userId,
                    Items = new List<CartItem>()
                };

                _context.Carts.Add(cart);
            }

            var existingItem = cart.Items!.FirstOrDefault(i => i.ProductId == productId);

            if (existingItem != null)
                existingItem.Quantity += cartItem.Quantity;
            else {
                var product = await _context.Products.FindAsync(productId);

                if(product != null) {
                    cart.Items!.Add(cartItem);
                }
            }

            await _context.SaveChangesAsync();
        }


        public async Task RemoveProductFromCartAsync(string userId, int cartItemId) {
            var cart = await GetCartByUserIdAsync(userId);

            var item = cart?.Items!.FirstOrDefault(i => i.Id == cartItemId);

            if(item != null) {
                cart?.Items!.Remove(item);

                await _context.SaveChangesAsync();
            }
            
        }

        public async Task ClearProductInCartAsync(string userId) {
            var cart = await GetCartByUserIdAsync(userId);
            if(cart != null) {
                cart.Items?.Clear();
                cart.Subtotal = 0;
                cart.TotalPrice = 0;

                await _context.SaveChangesAsync();
            }
        }

        public async Task IncreaseProductQuantityAsync(string userId, int cartItemId, int amount) {
            var cart = await GetCartByUserIdAsync(userId);

            var item = cart?.Items?.FirstOrDefault(i => i.Id == cartItemId);

            if (item != null && await CheckProductStockAsync(item.ProductId, item.Quantity + amount)) {
                item.Quantity += amount;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DecreaseProductQuantityAsync(string userId, int cartItemId, int amount) {
            var cart = await GetCartByUserIdAsync(userId);
            var item = cart?.Items?.FirstOrDefault(i => i.Id == cartItemId);

            if(item != null && item.Quantity - amount >= 1) {
                item.Quantity -= amount;
            }

            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckProductStockAsync(int productId, int quantity) {
            var product = await _context.Products.FindAsync(productId);

            if (product != null && product.StockQuantity >= quantity) {
                return true;
            }
            return false;
        }
    }
}
