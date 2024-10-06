using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using HomeDecorAPI.Domain.Exceptions.NullOfEmtyStringExeption;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services {
    public class FavoriteProductService : IFavoriteProductService {

        private readonly IFavoriteProductRepository _favoriteProductRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<FavoriteProductService> _logger;

        public FavoriteProductService(IFavoriteProductRepository favoriteProductRepository, IMapper mapper, UserManager<User> userManager, ILogger<FavoriteProductService> logger, IProductRepository productRepository)
        {
            _favoriteProductRepository = favoriteProductRepository;
            _mapper = mapper;
            _userManager = userManager;
            _logger = logger;
            _productRepository = productRepository;
        }

        public async Task AddProductToFavoritesAsync(string userId, int productId) {

            try {
                _logger.LogInformation($"Starting AddProductToFavoritesAsync method for User ID: {userId}, ProductId: {productId}");
                var user = await _userManager.FindByIdAsync(userId);

                if (user == null) {
                    _logger.LogWarning($"User not found with ID: {userId}");
                    throw new UserNotFoundException(userId);
                }
            
                var product = await _productRepository.GetByIdAsync(productId);

                if (product == null) {
                    _logger.LogWarning($"Product not found with ID: {productId}");
                    throw new ProductNotFoundException(productId.ToString());
                }
                var isInFavorites = await _favoriteProductRepository.IsProductInFavoritesAsync(userId, productId);

                if (isInFavorites) {
                    _logger.LogInformation($"Product ID: {productId} is already in User ID: {userId}'s favorites.");

                    await RemoveProductToFavoritesAsync(userId, productId);
                    return;
                }
                    

                var favoriteProduct = new FavoriteProduct {
                    UserId = userId,
                    ProductId = productId
                };

                await _favoriteProductRepository.AddAsync(favoriteProduct);
                await _favoriteProductRepository.SaveChangesAsync();
                _logger.LogInformation($"Successfully added Product ID: {productId} to User ID: {userId}'s favorites.");
                return;
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while adding product {ProductId} to user {UserId}'s favorites", productId, userId);
                throw;
            }
        }

        public async Task RemoveProductToFavoritesAsync(string userId, int productId) {
            try {

                _logger.LogInformation($"Starting AddProductToFavoritesAsync method for User ID: {userId}, ProductId: {productId}");
                var user = await _userManager.FindByIdAsync(userId);

                if (user == null) {
                    _logger.LogWarning($"User not found with ID: {userId}");
                    throw new UserNotFoundException(userId);
                }

                var product = await _productRepository.GetByIdAsync(productId);

                if (product == null) {
                    _logger.LogWarning($"Product not found with ID: {productId}");
                    throw new ProductNotFoundException(productId.ToString());
                }

                var favoriteProducts = await _favoriteProductRepository.GetFavoritesByUserIdAsync(userId);

                if (favoriteProducts == null || !favoriteProducts.Any()) {
                    _logger.LogInformation($"No favorite products found for User ID: {userId}");
                    throw new WishlistForUserIsEmptyException(userId);
                }

                var isInFavorites = await _favoriteProductRepository.IsProductInFavoritesAsync(userId, productId);

                if (!isInFavorites) {
                    _logger.LogInformation($"Product ID: {productId} is not already in User ID: {userId}'s favorites.");
                    throw new FavoriteProductNotException(productId.ToString());
                }
                var productToRemove = favoriteProducts.FirstOrDefault(fp => fp.ProductId == productId);
                if (productToRemove != null) {
                    favoriteProducts.Remove(productToRemove);
                    _logger.LogInformation($"Successfully removed Product ID: {productId} from favorite products.");
                } else {
                    _logger.LogWarning($"Product ID: {productId} not found in the favorite products.");
                }
                await _favoriteProductRepository.SaveChangesAsync();
                return;
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while removing product {ProductId} to user {UserId}'s favorites", productId, userId);
                throw;
            }
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductToFavoritesAsync(string userId) {
            try {
                _logger.LogInformation($"Retrieving all favorite products for User ID: {userId}");

                var favoriteProducts = await _favoriteProductRepository.GetFavoritesByUserIdAsync(userId);

                if (favoriteProducts == null || !favoriteProducts.Any()) {
                    _logger.LogInformation($"No favorite products found for User ID: {userId}");
                    throw new WishlistForUserIsEmptyException(userId);
                }
                var favoriteProductDtos = _mapper.Map<IEnumerable<ProductDto>>(favoriteProducts.Select(fp => fp.Product));

                _logger.LogInformation($"Successfully retrieved {favoriteProductDtos.Count()} favorite products for User ID: {userId}");
                return favoriteProductDtos;
            } catch (Exception ex) {
                _logger.LogError(ex, $"Error occurred while Retrieving user {userId}'s favorites");
                throw;
            }
        }

        public async Task RemoveAllFavoriteProductAsync(string userId) {
            try {
                _logger.LogInformation($"Removing all favorite products for User ID: {userId}");

                // Lấy tất cả sản phẩm yêu thích của người dùng
                var favoriteProducts = await _favoriteProductRepository.GetFavoritesByUserIdAsync(userId);

                if (favoriteProducts == null || !favoriteProducts.Any()) {
                    _logger.LogInformation($"No favorite products found for User ID: {userId}");
                    throw new WishlistForUserIsEmptyException(userId);
                }

                _favoriteProductRepository.RemoveRange(favoriteProducts);
                await _favoriteProductRepository.SaveChangesAsync();

                _logger.LogInformation($"Successfully removed all {favoriteProducts.Count()} favorite products for User ID: {userId}");
            } catch (Exception ex) {
                _logger.LogError(ex, $"Error occurred while removing all favorite products for User ID: {userId}'s favorites");
                throw;
            }
        }

    }
}
