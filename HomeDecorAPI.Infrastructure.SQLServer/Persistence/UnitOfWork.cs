using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using HomeDecorAPI.Infrastructure.SQLServer.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Persistence {
    public class UnitOfWork : IUnitOfWork, IDisposable {
        private readonly ApplicationDbContext _context;
        private IDbContextTransaction? _objTran = null;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IAddressRepository> _addressRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IFavoriteProductRepository> _favoriteProductRepository;
        private readonly Lazy<ICartRepository> _cartRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_context));
            _addressRepository = new Lazy<IAddressRepository>(() => new AddressRepository(_context));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(_context));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(_context));
            _favoriteProductRepository = new Lazy<IFavoriteProductRepository>(() => new FavoriteProductRepository(_context));
            _cartRepository = new Lazy<ICartRepository>(() => new CartRepository(_context));
        }

        public IUserRepository UserRepository => _userRepository.Value;
        public IAddressRepository AddressRepository => _addressRepository.Value;
        public IProductRepository ProductRepository => _productRepository.Value;
        public ICategoryRepository CategoryRepository => _categoryRepository.Value;
        public IFavoriteProductRepository FavoriteProductRepository => _favoriteProductRepository.Value;
        public ICartRepository CartRepository => _cartRepository.Value;

        public void CreateTransaction() {
            _objTran = _context.Database.BeginTransaction();
        }

        public void Commit() {
            _objTran?.Commit();
        }

        public void Rollback() {
            _objTran?.Rollback();

            _objTran?.Dispose();
        }

        public async Task SaveChangesAsync() {
            try {
                await _context.SaveChangesAsync();
            } catch(DbUpdateException ex) {
                throw new Exception(ex.Message , ex);
            }
        }

        public void Dispose() {
            _context.Dispose();
        }
    }
}
