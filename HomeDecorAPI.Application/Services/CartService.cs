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
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public CartService(IRepositoryManager repositoryManager, IMapper mapper) {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<CartDto> GetCartByUserIdAsync(string userId) {
            var cart = await _repositoryManager.CartRepository.GetCartByUserIdAsync(userId);
            return _mapper.Map<CartDto>(cart);
        }

        public async Task<IEnumerable<CartItemDto>> GetAllCartItemsForUserAsync(string userId) {
            var cartItems = await _repositoryManager.CartRepository.GetAllCartItemForUserAsync(userId);
            return _mapper.Map<IEnumerable<CartItemDto>>(cartItems);
        }

        public async Task AddProductToCartAsync(string userId, AddToCartDto addToCartDto) {
            var product = await _repositoryManager.ProductRepository.GetByIdAsync(addToCartDto.ProductId);
            if (product == null)
                throw new ProductNotFoundException($"Product with ID {addToCartDto.ProductId} not found.");

            if (!await _repositoryManager.CartRepository.CheckProductStockAsync(addToCartDto.ProductId, addToCartDto.Quantity))
                throw new InvalidOperationException("Insufficient stock.");

            await _repositoryManager.CartRepository.AddProductToCartAsync(userId, addToCartDto.ProductId, addToCartDto.Quantity);
        }

        public async Task RemoveProductFromCartAsync(string userId, int cartItemId) {
            await _repositoryManager.CartRepository.RemoveProductFromCartAsync(userId, cartItemId);
        }

        public async Task ClearCartAsync(string userId) {
            await _repositoryManager.CartRepository.ClearCartAsync(userId);
        }

        public async Task UpdateCartItemQuantityAsync(string userId, int cartItemId, int newQuantity) {
            await _repositoryManager.CartRepository.UpdateCartItemQuantityAsync(userId, cartItemId, newQuantity);
        }

        public async Task UpdateCartShippingCostAsync(string userId, decimal shippingCost) {
            await _repositoryManager.CartRepository.UpdateCartShippingCostAsync(userId, shippingCost);
        }

        public async Task ApplyDiscountAsync(string userId, decimal discountAmount) {
            await _repositoryManager.CartRepository.ApplyDiscountAsync(userId, discountAmount);
        }
    }
}