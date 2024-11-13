using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using HomeDecorAPI.Infrastructure.SQLServer.Persistence.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Domain.Entities;

namespace HomeDecorAPI.Infrastructure.SQLServer.Persistence {
    public class UnitOfWork : IUnitOfWork, IAsyncDisposable {
        private readonly ApplicationDbContext _context;
        private IDbContextTransaction? _transaction;
        private bool _disposed;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IAddressRepository> _addressRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IWishlistRepository> _wishlistRepository;
        private readonly Lazy<ICartRepository> _cartRepository;
        private readonly Lazy<IBrandRepository> _brandRepository;
        private readonly Lazy<ISupplierRepository> _supplierRepository;
        public UnitOfWork(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_context, userManager));
            _addressRepository = new Lazy<IAddressRepository>(() => new AddressRepository(_context));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(_context));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(_context));
			_wishlistRepository = new Lazy<IWishlistRepository>(() => new WishlistRepository(_context));
            _cartRepository = new Lazy<ICartRepository>(() => new CartRepository(_context));
            _brandRepository = new Lazy<IBrandRepository>(() => new BrandRepository(_context));
            _supplierRepository = new Lazy<ISupplierRepository>(() => new SupplierRepository(_context));
        }

        public IBrandRepository BrandRepository => _brandRepository.Value;
        public IUserRepository UserRepository => _userRepository.Value;
        public IAddressRepository AddressRepository => _addressRepository.Value;
        public IProductRepository ProductRepository => _productRepository.Value;
        public ICategoryRepository CategoryRepository => _categoryRepository.Value;
        public IWishlistRepository FavoriteProductRepository => _wishlistRepository.Value;
        public ICartRepository CartRepository => _cartRepository.Value;
        public ISupplierRepository SupplierRepository => _supplierRepository.Value;
        public async Task BeginTransactionAsync()
        {
            if (_transaction != null)
            {
                throw new InvalidOperationException("A transaction is already in progress.");
            }

            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                await SaveChangesAsync();
                await _transaction?.CommitAsync();
            }
            finally
            {
                if (_transaction != null)
                {
                    await _transaction.DisposeAsync();
                    _transaction = null;
                }
            }
        }

        public async Task RollbackAsync()
        {
            try
            {
                await _transaction?.RollbackAsync();
            }
            finally
            {
                if (_transaction != null)
                {
                    await _transaction.DisposeAsync();
                    _transaction = null;
                }
            }
        }

        public async Task SaveChangesAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Log the exception details
                throw new Exception("An error occurred while saving changes to the database.", ex);
            }
        }

        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore();
            GC.SuppressFinalize(this);
        }

        protected virtual async ValueTask DisposeAsyncCore()
        {
            if (!_disposed)
            {
                if (_transaction != null)
                {
                    await _transaction.DisposeAsync();
                }

                await _context.DisposeAsync();
                _disposed = true;
            }
        }
    }
}
