using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services {
    public class FavoriteProductService : IFavoriteProductService {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public FavoriteProductService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<bool> AddProductAsync(string userId, int productId) {
            var existingFavorite = await _repositoryManager.FavoriteProductRepository.FirstOrDefaultAsync(fp => fp.UserId == userId && fp.ProductId == productId);

            if (existingFavorite != null) 
                return false;

            var favoriteProduct = new FavoriteProduct {
                UserId = userId,
                ProductId = productId
            };

            await _repositoryManager.FavoriteProductRepository.AddAsync(favoriteProduct);
            await _repositoryManager.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveFavoriteProductAsync(string userId, int productId) {
            var favoriteProduct = await _repositoryManager.FavoriteProductRepository.FirstOrDefaultAsync(fp => fp.UserId == userId && fp.ProductId == productId);

            if (favoriteProduct == null)
                return false;

            await _repositoryManager.FavoriteProductRepository.RemoveAsync(favoriteProduct);
            await _repositoryManager.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<ProductDto>> GetAllFavoriteProductsAsync(string userId) {
            var favoriteProductList = await _repositoryManager.FavoriteProductRepository
                .FindByCondition(fp => fp.UserId == userId)
                .Select(fp => fp.Product)
                .ToListAsync();

            return _mapper.Map<IEnumerable<ProductDto>>(favoriteProductList);
        }

        public async Task<bool> RemoveAllFavoriteProductAsync(string userId) {
            var favoriteProducts = await _repositoryManager.FavoriteProductRepository
                .FindByCondition(fp => fp.UserId == userId)
                .ToListAsync();

            if (!favoriteProducts.Any())
                return false;

            await _repositoryManager.FavoriteProductRepository.RemoveRangeAsync(favoriteProducts);
            await _repositoryManager.SaveChangesAsync();

            return true;
        }
    }
}
