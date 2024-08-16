using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Repositories {
    public sealed class RepositoryManager : IRepositoryManager {
        private readonly ApplicationDbContext _applicationContext;

        private readonly Lazy<IAddressRepository> _addressRepository;

        public RepositoryManager(ApplicationDbContext applicationContext, IAddressRepository addressRepository) {
            _applicationContext = applicationContext;   
            _addressRepository = new Lazy<IAddressRepository>(() => new AddressRepository(applicationContext));
        }

        public async Task SaveAsync() => await _applicationContext.SaveChangesAsync();
        public IAddressRepository AddressRepository => _addressRepository.Value;
    }
}
