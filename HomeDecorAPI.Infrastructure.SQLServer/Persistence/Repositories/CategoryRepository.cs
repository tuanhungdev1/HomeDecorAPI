using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Persistence.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {

        private readonly ApplicationDbContext _applicationDbContext;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _applicationDbContext = context;
        }

        public async Task<IEnumerable<Category>?> GetSubcategoriesByParentCategory(int parentCategoryId)
        {
            var category = await _applicationDbContext.Set<Category>()
                .Include(c => c.SubCategories)
                .Where(c => c.Id == parentCategoryId)
                .SingleOrDefaultAsync();

            if (category == null)
                return null;
            return category.SubCategories;
        }
    }
}
