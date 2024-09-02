using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationDbContext _applicationContext;

        private readonly Lazy<IAddressRepository> _addressRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IFavoriteProductRepository> _favoriteProductRepository;

        public RepositoryManager(ApplicationDbContext applicationContext)
        {
            _applicationContext = applicationContext;
            _addressRepository = new Lazy<IAddressRepository>(() => new AddressRepository(applicationContext));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(applicationContext));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(applicationContext));
            _favoriteProductRepository = new Lazy<IFavoriteProductRepository>(() => new FavoriteProductRepository(applicationContext));
        }
        public IAddressRepository AddressRepository => _addressRepository.Value;
        public IProductRepository ProductRepository => _productRepository.Value;
        public ICategoryRepository CategoryRepository => _categoryRepository.Value;
        
        public IFavoriteProductRepository FavoriteProductRepository => _favoriteProductRepository.Value;
        public async Task SaveChangesAsync() {
            await _applicationContext.SaveChangesAsync();
        }
    }
}
