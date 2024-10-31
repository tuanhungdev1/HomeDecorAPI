using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.RequestFeatures;
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

        public async Task<PagedList<Category>> GetAllCategories(CategoryRequestParameters categoryRequestParameters)
        {
            var query = _context.Categories.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(categoryRequestParameters.SearchTerm))
            {
                query = query.Where(b => b.Name.Contains(categoryRequestParameters.SearchTerm));
            }

            if (!string.IsNullOrWhiteSpace(categoryRequestParameters.Name))
            {
                query = query.Where(b => b.Name.Contains(categoryRequestParameters.Name));
            }

            if (categoryRequestParameters.IsActive.HasValue)
            {
                query = query.Where(b => b.IsActive == categoryRequestParameters.IsActive.Value);
            }

            if (categoryRequestParameters.StartDate.HasValue)
            {
                query = query.Where(b => b.CreatedAt >= categoryRequestParameters.StartDate.Value);
            }

            if (categoryRequestParameters.EndDate.HasValue)
            {
                query = query.Where(b => b.CreatedAt <= categoryRequestParameters.EndDate.Value);
            }

            query = ApplySorting(query, categoryRequestParameters.SortKey, categoryRequestParameters.OrderBy);


            var totalCount = await query.CountAsync();


            var items = await query
                .Skip((categoryRequestParameters.PageNumber - 1) * categoryRequestParameters.PageSize)
                .Take(categoryRequestParameters.PageSize)
                .ToListAsync();


            return new PagedList<Category>(items, totalCount, categoryRequestParameters.PageNumber, categoryRequestParameters.PageSize);
        }


        private IQueryable<Category> ApplySorting(IQueryable<Category> query, string? sortKey, string? orderBy)
        {
            if (string.IsNullOrEmpty(sortKey))
            {
                return query.OrderBy(b => b.Name);
            }

            var isDesending = orderBy?.ToLower() == "desc";

            query = sortKey.ToLower() switch
            {
                "id" => isDesending ? query.OrderByDescending(b => b.Id) : query.OrderBy(b => b.Id),
                "name" => isDesending ? query.OrderByDescending(b => b.Name) : query.OrderBy(b => b.Name),
                "createdat" => isDesending ? query.OrderByDescending(b => b.CreatedAt) : query.OrderBy(b => b.CreatedAt),
                "description" => isDesending ? query.OrderByDescending(b => b.Description) : query.OrderBy(b => b.Description),
                _ => query.OrderBy(b => b.Id),
            };

            return query;
        }
        public async Task<ICollection<Category>> GetSubcategoriesByParentCategory(int parentCategoryId)
        {
            var category = await _applicationDbContext.Categories
                .Where(c => c.Id == parentCategoryId)
                .Include(c => c.SubCategories)
                .SingleOrDefaultAsync();
            return category.SubCategories ?? new List<Category>();
        }
    }
}
