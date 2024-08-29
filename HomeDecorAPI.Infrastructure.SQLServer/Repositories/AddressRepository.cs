using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;


namespace HomeDecorAPI.Infrastructure.SQLServer.Repositories
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
