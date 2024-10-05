using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Interfaces {
    public interface IUnitOfWork : IDisposable {
        public IUserRepository UserRepository { get; }
        public IAddressRepository AddressRepository { get; }
        public IProductRepository ProductRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public IFavoriteProductRepository FavoriteProductRepository { get; }
        public ICartRepository CartRepository { get; }
        void CreateTransaction();
        void Commit();
        void Rollback();
        Task SaveChangesAsync();
    }
}
