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

        public RepositoryManager(ApplicationDbContext applicationContext)
        {
            _applicationContext = applicationContext;
            _addressRepository = new Lazy<IAddressRepository>(() => new AddressRepository(applicationContext));
        }
        public IAddressRepository AddressRepository => _addressRepository.Value;
    }
}
