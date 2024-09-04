using AutoMapper;
using HomeDecorAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using HomeDecorAPI.Application.Shared.Messages;
using Microsoft.EntityFrameworkCore;

namespace HomeDecorAPI.Application.Services.Cart {
    internal class CartService : ICartService {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        public CartService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<User> userManager)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<bool> AddItemToCartAsync(string userId, int productId) {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                throw new UserNotFoundException(ErrorMessages.Entity.NotFound("User", userId));

            var product = await _repositoryManager.ProductRepository.GetByIdAsync(productId);
            if (product == null)
                throw new ProductNotFoundException(ErrorMessages.Entity.NotFound("Product", userId));

            var productExistsInCart = await _repositoryManager.CartRepository.FindByCondition(c => c.UserId == userId)
                                                                             .Include(c => c.Items)
                                                                             .ToListAsync();
                                                          
               
        }
    }
}
