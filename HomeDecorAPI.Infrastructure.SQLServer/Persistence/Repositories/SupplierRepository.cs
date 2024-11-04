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
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {

        private readonly ApplicationDbContext _context;
        public SupplierRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PagedList<Supplier>> GetAllSupplierAsync(SupplierRequestParameters supplierRequestParameters)
        {
            var query = _context.Suppliers.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(supplierRequestParameters.SearchTerm))
            {
                query = query.Where(b => b.Name.Contains(supplierRequestParameters.SearchTerm));
            }

            if (!string.IsNullOrWhiteSpace(supplierRequestParameters.Name))
            {
                query = query.Where(b => b.Name.Contains(supplierRequestParameters.Name));
            }

            if (supplierRequestParameters.IsActive.HasValue)
            {
                query = query.Where(b => b.IsActive == supplierRequestParameters.IsActive.Value);
            }

            if (supplierRequestParameters.StartDate.HasValue)
            {
                query = query.Where(b => b.CreatedAt >= supplierRequestParameters.StartDate.Value);
            }

            if (supplierRequestParameters.EndDate.HasValue)
            {
                query = query.Where(b => b.CreatedAt <= supplierRequestParameters.EndDate.Value);
            }

            query = ApplySorting(query, supplierRequestParameters.SortKey, supplierRequestParameters.OrderBy);


            var totalCount = await query.CountAsync();


            var items = await query
                .Skip((supplierRequestParameters.PageNumber - 1) * supplierRequestParameters.PageSize)
                .Take(supplierRequestParameters.PageSize)
                .ToListAsync();


            return new PagedList<Supplier>(items, totalCount, supplierRequestParameters.PageNumber, supplierRequestParameters.PageSize);
        }

        private IQueryable<Supplier> ApplySorting(IQueryable<Supplier> query, string? sortKey, string? orderBy)
        {
            if (string.IsNullOrEmpty(sortKey))
            {
                return query.OrderBy(b => b.Name);
            }

            var isDesending = orderBy?.ToLower() == "desc";

            query = sortKey.ToLower() switch
            {
                "id" => isDesending ? query.OrderByDescending(b => b.Id) : query.OrderBy(b => b.Id),
                "contactperson" => isDesending ? query.OrderByDescending(b => b.ContactPerson) : query.OrderBy(b => b.ContactPerson),
                "name" => isDesending ? query.OrderByDescending(b => b.Name) : query.OrderBy(b => b.Name),
                "phone" => isDesending ? query.OrderByDescending(b => b.Phone) : query.OrderBy(b => b.Phone),
                "city" => isDesending ? query.OrderByDescending(b => b.City) : query.OrderBy(b => b.City),
                "country" => isDesending ? query.OrderByDescending(b => b.Country) : query.OrderBy(b => b.Country),
                "address" => isDesending ? query.OrderByDescending(b => b.Address) : query.OrderBy(b => b.Address),
                "createdat" => isDesending ? query.OrderByDescending(b => b.CreatedAt) : query.OrderBy(b => b.CreatedAt),
                "description" => isDesending ? query.OrderByDescending(b => b.Description) : query.OrderBy(b => b.Description),
                _ => query.OrderBy(b => b.Id),
            };

            return query;
        }
    }
}
