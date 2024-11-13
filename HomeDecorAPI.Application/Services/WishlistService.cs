using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.CartDtos;
using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.DTOs.WishlistDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.BadRequestException;
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
    public class WishlistService : IWishlistService
	{

        private readonly IWishlistRepository _wishlistRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly ILoggerService _logger;
        private readonly IUnitOfWork _unitOfWork;

        public WishlistService(IWishlistRepository wishlistRepository,
                                IMapper mapper,
                                UserManager<User> userManager,
                                ILoggerService logger,
                                IProductRepository productRepository,
                                IUnitOfWork unitOfWork
        )
        {
			_wishlistRepository = wishlistRepository;
            _mapper = mapper;
            _userManager = userManager;
            _logger = logger;
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
       }

		public async Task<(IEnumerable<WishlistItemDto> Items, MetaData MetaData)> GetUserWishlistAsync(
		string userId, WishlistRequestParameters parameters)
		{
            var user = await _userManager.FindByIdAsync(userId); 
            if(user == null)
            {
                _logger.LogError($"Không thể thêm sản phẩm vào Wishlist của User không tồn tại với ID:{userId}");
				throw new UserBadRequestException($"Không thể thêm sản phẩm vào Wishlist của User không tồn tại với ID:{userId}");
			}
			var wishlistItems = await _wishlistRepository.GetUserWishlistAsync(userId, parameters);
			var wishlistItemDtos = _mapper.Map<IEnumerable<WishlistItemDto>>(wishlistItems);

			return (wishlistItemDtos, wishlistItems.MetaData);
		}

		public async Task<WishlistItemDto> AddToWishlistAsync(string userId, int productId)
		{
			var product = await _productRepository.GetByIdAsync(productId)
				?? throw new ProductBadRequestException($"Product with id {productId} not found");

			if (await _wishlistRepository.ExistsAsync(userId, productId))
				throw new ProductBadRequestException("Product already in wishlist");

			var wishlistItem = new WishlistItem
			{
				UserId = userId,
				ProductId = productId,
				DateAdded = DateTime.UtcNow
			};

			try
			{
				await _unitOfWork.BeginTransactionAsync();
				await _wishlistRepository.AddAsync(wishlistItem);
				await _unitOfWork.CommitAsync();

				return _mapper.Map<WishlistItemDto>(wishlistItem);
			}
			catch (Exception ex)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError($"Error adding product to wishlist: {ex.Message}");
				throw;
			}
		}

		public async Task RemoveFromWishlistAsync(string userId, int productId)
		{
			var wishlistItem = await _wishlistRepository.GetAsync(userId, productId)
				?? throw new ProductBadRequestException("Product not found in wishlist");

			try
			{
				await _unitOfWork.BeginTransactionAsync();
				await _wishlistRepository.RemoveAsync(wishlistItem);
				await _unitOfWork.CommitAsync();
			}
			catch (Exception ex)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError($"Error removing product from wishlist: {ex.Message}");
				throw;
			}
		}


		public async Task<bool> CheckInWishlistAsync(string userId, int productId)
		{
			return await _wishlistRepository.ExistsAsync(userId, productId);
		}

		public async Task MoveAllToCartAsync(string userId)
		{
			var wishlistItems = await _wishlistRepository.GetAllAsync(userId);

			try
			{
				await _unitOfWork.BeginTransactionAsync();

				foreach (var item in wishlistItems)
				{
					var product = await _productRepository.GetByIdAsync(item.ProductId);
					if (product != null)
					{
						await _cartService.AddToCartAsync(userId, new AddToCartDto
						{
							ProductId = item.ProductId,
							Quantity = 1
						});
						await _wishlistRepository.RemoveAsync(item);
					}
				}

				await _unitOfWork.CommitAsync();
			}
			catch (Exception ex)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError($"Error moving items to cart: {ex.Message}");
				throw;
			}
		}

		public async Task ClearWishlistAsync(string userId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();
				await _wishlistRepository.ClearAsync(userId);
				await _unitOfWork.CommitAsync();
			}
			catch (Exception ex)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError($"Error clearing wishlist: {ex.Message}");
				throw;
			}
		}
	}
}
