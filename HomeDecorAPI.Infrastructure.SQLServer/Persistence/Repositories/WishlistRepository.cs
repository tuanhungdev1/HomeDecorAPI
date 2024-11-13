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
    public class WishlistRepository : RepositoryBase<WishlistItem>, IWishlistRepository
    {

        private readonly ApplicationDbContext _context;
        public WishlistRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PagedList<WishlistItem>> GetUserWishlistAsync(string userId, WishlistRequestParameters parameters)
        {
            var query = _context.WishlistItems
                                            .AsNoTracking()
                                            .Include(w => w.ProductVariant)
                                            .ThenInclude(pv => pv.Images)
                                            .Where(w => w.UserId == userId)
                                            .AsQueryable();

            if(!string.IsNullOrWhiteSpace(parameters.SearchTerm))
            {
                query = query.Where(w => w.ProductVariant.Product.Name.Contains(parameters.SearchTerm));
            }

			if (parameters.MinPrice.HasValue)
				query = query.Where(w => w.ProductVariant.Product.ProductVariants.Any(pv => pv.OriginalPrice >= parameters.MinPrice.Value));

			if (parameters.MaxPrice.HasValue)
				query = query.Where(w => w.ProductVariant.Product.ProductVariants.Any(pv => pv.OriginalPrice <= parameters.MaxPrice.Value));

            if(parameters.CategoryId.HasValue)
                query = query.Where(w => w.ProductVariant.Product.CategoryId.Value == parameters.CategoryId.Value);
            
			if (parameters.BrandId.HasValue)
				query = query.Where(w => w.ProductVariant.Product.BrandId.Value == parameters.BrandId.Value);

            if(parameters.DateAddedFrom.HasValue)
                query = query.Where(w => w.DateAdded >=  parameters.DateAddedFrom.Value);

            if(parameters.DateAddedTo.HasValue)
                query = query.Where(w => w.DateAdded <= parameters.DateAddedTo.Value);

            query = ApplySorting(query, parameters.SortKey, parameters.OrderBy);

            var totalCount = await query.CountAsync();

			var items = await query
				.Skip((parameters.PageNumber - 1) * parameters.PageSize)
				.Take(parameters.PageSize)
				.ToListAsync();


			return new PagedList<WishlistItem>(items, totalCount, parameters.PageNumber, parameters.PageSize);
		}

		private IQueryable<WishlistItem> ApplySorting(IQueryable<WishlistItem> query, string? sortKey, string? orderBy)
		{
			if (string.IsNullOrEmpty(sortKey))
			{
				return query.OrderByDescending(w => w.DateAdded);
			}

			var isDesending = orderBy?.ToLower() == "desc";

			query = sortKey.ToLower() switch
			{
				"dateadded" => isDesending ? query.OrderByDescending(b => b.DateAdded) : query.OrderBy(b => b.DateAdded),
				"name" => isDesending ? query.OrderByDescending(b => b.ProductVariant.Product.Name) : query.OrderBy(b => b.ProductVariant.Product.Name),
				"price" => isDesending ? query.OrderByDescending(b => b.ProductVariant.OriginalPrice) : query.OrderBy(b => b.ProductVariant.OriginalPrice),
				_ => query.OrderBy(b => b.DateAdded),
			};

			return query;
		}

        public async Task<WishlistItem> GetAsync(string userId, int productVariantId)
        {
            return await _context.WishlistItems
                .FirstOrDefaultAsync(w => w.UserId == userId && w.ProductVariantId == productVariantId);
        }

        public async Task<IEnumerable<WishlistItem>> GetAllAsync(string userId)
        {
            return await _context.WishlistItems
                .Include(w => w.ProductVariant)
                .ThenInclude(pv => pv.Images)
                .Where(w => w.UserId == userId)
                .ToListAsync();
        }

        public async Task<bool> ExistsAsync(string userId, int productVariantId)
        {
            return await _context.WishlistItems.AnyAsync(w => w.UserId == userId && w.ProductVariantId == productVariantId);
        }

		public async Task AddAsync(WishlistItem wishlistItem)
		{
			await _context.WishlistItems.AddAsync(wishlistItem);
		}

		public async Task RemoveAsync(WishlistItem wishlistItem)
		{
			_context.WishlistItems.Remove(wishlistItem);
		}

		public async Task ClearAsync(string userId)
		{
			var items = await _context.WishlistItems
				.Where(w => w.UserId == userId)
				.ToListAsync();

			_context.WishlistItems.RemoveRange(items);
		}

		public async Task<int> GetWishlistCountAsync(string userId)
		{
			return await _context.WishlistItems
				.Where(w => w.UserId == userId)
				.CountAsync();
		}
	}
}
