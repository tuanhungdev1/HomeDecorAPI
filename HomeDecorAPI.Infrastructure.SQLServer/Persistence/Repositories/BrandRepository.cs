using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Application.Shared.Utilities;
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
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        private readonly ApplicationDbContext _context;

        public BrandRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PagedList<Brand>> getAllSupplierAsync(BrandRequestParameters brandRequestParameters)
        {
            var query = _context.Brands.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(brandRequestParameters.SearchTerm))
            {
                query = query.Where(b => b.Name.Contains(brandRequestParameters.SearchTerm));
            }

            if (!string.IsNullOrWhiteSpace(brandRequestParameters.Name))
            {
                query = query.Where(b => b.Name.Contains(brandRequestParameters.Name));
            }

            if (brandRequestParameters.IsActive.HasValue)
            {
                query = query.Where(b => b.IsActive == brandRequestParameters.IsActive.Value);
            }

            if (brandRequestParameters.StartDate.HasValue)
            {
                query = query.Where(b => b.CreatedAt >= brandRequestParameters.StartDate.Value);
            }

            if (brandRequestParameters.EndDate.HasValue)
            {
                query = query.Where(b => b.CreatedAt <= brandRequestParameters.EndDate.Value);
            }

            query = ApplySorting(query, brandRequestParameters.SortKey, brandRequestParameters.OrderBy);

            
            var totalCount = await query.CountAsync();

            
            var items = await query
                .Skip((brandRequestParameters.PageNumber - 1) * brandRequestParameters.PageSize)
                .Take(brandRequestParameters.PageSize)
                .ToListAsync();

           
            return new PagedList<Brand>(items, totalCount, brandRequestParameters.PageNumber, brandRequestParameters.PageSize);
        }


        private IQueryable<Brand> ApplySorting(IQueryable<Brand> query, string? sortKey, string? orderBy)
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

    }
}
