using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Repositories {
    public class FavoriteProductRepository : RepositoryBase<FavoriteProduct>, IFavoriteProductRepository {
        public FavoriteProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
