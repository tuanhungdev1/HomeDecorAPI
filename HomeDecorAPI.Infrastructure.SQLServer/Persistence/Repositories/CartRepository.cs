using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using Microsoft.EntityFrameworkCore;

using HomeDecorAPI.Domain.Exceptions.NotFoundException;

namespace HomeDecorAPI.Infrastructure.SQLServer.Persistence.Repositories
{
    public class CartRepository : RepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }

        public async Task<Cart> GetCartByUserIdAsync(string userId)
        {
            var cart = await _context.Carts
                .Include(c => c.Items)
                .ThenInclude(i => i.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            return cart ?? new Cart { UserId = userId };
        }

        public async Task<IEnumerable<CartItem>> GetAllCartItemForUserAsync(string userId)
        {
            var cart = await GetCartByUserIdAsync(userId);
            return cart.Items ?? Enumerable.Empty<CartItem>();
        }

        public async Task AddProductToCartAsync(string userId, int productId, int quantity)
        {
            var cart = await GetCartByUserIdAsync(userId);
            var product = await _context.Products.FindAsync(productId);

            if (product == null)
                throw new ProductNotFoundException($"Product with ID {productId} not found.");

            var existingItem = cart.Items?.FirstOrDefault(i => i.ProductId == productId);

            if (existingItem != null)
                existingItem.Quantity += quantity;
            else
            {
                cart.Items ??= new List<CartItem>();
                cart.Items.Add(new CartItem
                {
                    ProductId = productId,
                    Quantity = quantity,
                    Product = product
                });
            }

            cart.LastModifiedDate = DateTime.UtcNow;
            await _context.SaveChangesAsync();
        }

        public async Task RemoveProductFromCartAsync(string userId, int cartItemId)
        {
            var cart = await GetCartByUserIdAsync(userId);
            var item = cart.Items?.FirstOrDefault(i => i.Id == cartItemId);

            if (item != null)
            {
                cart.Items?.Remove(item);
                cart.LastModifiedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
        }

        public async Task ClearCartAsync(string userId)
        {
            var cart = await GetCartByUserIdAsync(userId);
            if (cart.Items != null)
            {
                cart.Items.Clear();
                cart.LastModifiedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateCartItemQuantityAsync(string userId, int cartItemId, int newQuantity)
        {
            var cart = await GetCartByUserIdAsync(userId);
            var item = cart.Items?.FirstOrDefault(i => i.Id == cartItemId);

            if (item == null)
                throw new CartNotFoundException($"Cart item with ID {cartItemId} not found.");

            if (newQuantity < 1)
                throw new ArgumentException("Quantity must be at least 1.");

            if (await CheckProductStockAsync(item.ProductId, newQuantity))
            {
                item.Quantity = newQuantity;
                item.UpdatedAt = DateTime.UtcNow;
                cart.LastModifiedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
            else
                throw new InvalidOperationException("Insufficient stock.");
        }

        public async Task<bool> CheckProductStockAsync(int productId, int quantity)
        {
            var product = await _context.Products.FindAsync(productId);
            return product != null;
        }

        public async Task UpdateCartShippingCostAsync(string userId, decimal shippingCost)
        {
            var cart = await GetCartByUserIdAsync(userId);
            cart.ShippingCost = shippingCost;
            cart.LastModifiedDate = DateTime.UtcNow;
            await _context.SaveChangesAsync();
        }

        public async Task ApplyDiscountAsync(string userId, decimal discountAmount)
        {
            var cart = await GetCartByUserIdAsync(userId);
            cart.Discount = discountAmount;
            cart.LastModifiedDate = DateTime.UtcNow;
            await _context.SaveChangesAsync();
        }
    }
}