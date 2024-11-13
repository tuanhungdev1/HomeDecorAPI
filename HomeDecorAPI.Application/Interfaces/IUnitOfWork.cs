using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Interfaces {
    public interface IUnitOfWork : IAsyncDisposable {
        public IUserRepository UserRepository { get; }
        public IAddressRepository AddressRepository { get; }
        public IProductRepository ProductRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public IWishlistRepository FavoriteProductRepository { get; }
        public ICartRepository CartRepository { get; }
        public IBrandRepository BrandRepository { get; }
        public ISupplierRepository SupplierRepository { get; }
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
        Task SaveChangesAsync();
    }
}
