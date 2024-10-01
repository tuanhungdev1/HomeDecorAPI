using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services
{
    public sealed class ServiceManager : IServiceManager {

        private readonly Lazy<IAuthenticationService> _authenticationService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IFileUploadService> _fileUploadService; 
        private readonly Lazy<IAddressService> _addressService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<IFavoriteProductService> _favoriteProductService;
        private readonly Lazy<ICartService> _cartService;

        public ServiceManager(IHttpContextAccessor httpContextAccessor, IRepositoryManager repositoryManager, IOptions<CloudinarySettings> config, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration) {
            _authenticationService = new Lazy<IAuthenticationService>(() =>
             new AuthenticationService(httpContextAccessor, repositoryManager, mapper, userManager, signInManager, configuration));

            _userService = new Lazy<IUserService>(() => new UserService(userManager, mapper));

            _fileUploadService = new Lazy<IFileUploadService>(() => new FileUploadService(userManager));

            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, mapper));

            _categoryService = new Lazy<ICategoryService> (() => new CategoryService(repositoryManager, mapper));

            _favoriteProductService = new Lazy<IFavoriteProductService>(() => new FavoriteProductService(repositoryManager, mapper));

            _cartService = new Lazy<ICartService>(() => new CartService(repositoryManager, mapper));
        }
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
        public IUserService UserService => _userService.Value;
        public IFileUploadService FileUploadService => _fileUploadService.Value;
        public IAddressService AddressService => _addressService.Value;
        public IProductService ProductService => _productService.Value;
        public ICategoryService CategoryService => _categoryService.Value;
        public IFavoriteProductService FavoriteProductService => _favoriteProductService.Value;
        public ICartService CartService => _cartService.Value;
    }
}
