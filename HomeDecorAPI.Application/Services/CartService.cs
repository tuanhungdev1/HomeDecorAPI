using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.CartDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services
{
    public class CartService : ICartService {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        public CartService(ICartRepository cartRepository, IMapper mapper) {
            _cartRepository = cartRepository;
            _mapper = mapper;
        }

        public async Task<CartDto> GetCartByUserIdAsync(string userId) {
            var cart = await _cartRepository.GetCartByUserIdAsync(userId);
            return _mapper.Map<CartDto>(cart);
        }

        public async Task<IEnumerable<CartItemDto>> GetAllCartItemsForUserAsync(string userId) {
            var cartItems = await _cartRepository.GetAllCartItemForUserAsync(userId);
            return _mapper.Map<IEnumerable<CartItemDto>>(cartItems);
        }

        public async Task AddProductToCartAsync(string userId, AddToCartDto addToCartDto) {
            var product = await _cartRepository.GetByIdAsync(addToCartDto.ProductId);
            if (product == null)
                throw new ProductNotFoundException($"Product with ID {addToCartDto.ProductId} not found.");

            if (!await _cartRepository.CheckProductStockAsync(addToCartDto.ProductId, addToCartDto.Quantity))
                throw new InvalidOperationException("Insufficient stock.");

            await _cartRepository.AddProductToCartAsync(userId, addToCartDto.ProductId, addToCartDto.Quantity);
        }

        public async Task RemoveProductFromCartAsync(string userId, int cartItemId) {
            await _cartRepository.RemoveProductFromCartAsync(userId, cartItemId);
        }

        public async Task ClearCartAsync(string userId) {
            await _cartRepository.ClearCartAsync(userId);
        }

        public async Task UpdateCartItemQuantityAsync(string userId, int cartItemId, int newQuantity) {
            await _cartRepository.UpdateCartItemQuantityAsync(userId, cartItemId, newQuantity);
        }

        public async Task UpdateCartShippingCostAsync(string userId, decimal shippingCost) {
            await _cartRepository.UpdateCartShippingCostAsync(userId, shippingCost);
        }

        public async Task ApplyDiscountAsync(string userId, decimal discountAmount) {
            await _cartRepository.ApplyDiscountAsync(userId, discountAmount);
        }
    }
}