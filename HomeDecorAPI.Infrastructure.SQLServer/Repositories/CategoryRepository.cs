using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Repositories {
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
