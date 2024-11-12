using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Persistence.Repositories {
    public class UserRepository : RepositoryBase<User>, IUserRepository {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        public UserRepository(ApplicationDbContext context, UserManager<User> userManager) : base(context)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<PagedList<User>> GetAllUserAsync(UserRequestParameters userRequestParameters)
        {
            var query = _context.Users.AsNoTracking().AsQueryable();

            if(!string.IsNullOrWhiteSpace(userRequestParameters.SearchTerm))
            {
                query = query.Where(u => u.UserName.Contains(userRequestParameters.SearchTerm, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(userRequestParameters.Status))
            {
                query = query.Where(u => u.Status == userRequestParameters.Status);
            }

            if (userRequestParameters.StartAge.HasValue)
            {
                query = query.Where(u => u.Age >= userRequestParameters.StartAge.Value);
            }

            if (userRequestParameters.EndAge.HasValue)
            {
                query = query.Where(u => u.Age <= userRequestParameters.EndAge.Value);
            }

            if (!string.IsNullOrWhiteSpace(userRequestParameters.Country))
            {
                query = query.Where(u => u.Country == userRequestParameters.Country);
            }

            if (!string.IsNullOrWhiteSpace(userRequestParameters.City))
            {
                query = query.Where(u => u.City == userRequestParameters.City);
            }

            if (userRequestParameters.CreatedAfter.HasValue)
            {
                query = query.Where(u => u.CreatedAt >= userRequestParameters.CreatedAfter.Value);
            }

            if (userRequestParameters.CreatedBefore.HasValue)
            {
                query = query.Where(u => u.CreatedAt <= userRequestParameters.CreatedBefore.Value);
            }
            if (userRequestParameters.Roles != null && userRequestParameters.Roles.Any())
            {
                var usersWithRoles = new List<User>();
                foreach (var user in query.ToList())
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles.Any(role => userRequestParameters.Roles.Contains(role)))
                    {
                        usersWithRoles.Add(user);
                    }
                }
                query = usersWithRoles.AsQueryable();
            }

            query = ApplySorting(query, userRequestParameters.SortKey, userRequestParameters.OrderBy);

            var totalCount = await query.CountAsync();

            var items = await query
               .Skip((userRequestParameters.PageNumber - 1) * userRequestParameters.PageSize)
               .Take(userRequestParameters.PageSize)
               .ToListAsync();


            return new PagedList<User>(items, totalCount, userRequestParameters.PageNumber, userRequestParameters.PageSize);

        }

        private IQueryable<User> ApplySorting(IQueryable<User> query, string? sortKey, string? orderBy)
        {
            if (string.IsNullOrEmpty(sortKey))
            {
                return query.OrderBy(b => b.Id);
            }

            var isDesending = orderBy?.ToLower() == "desc";

            query = sortKey.ToLower() switch
            {
                "id" => isDesending ? query.OrderByDescending(b => b.Id) : query.OrderBy(b => b.Id),
                "username" => isDesending ? query.OrderByDescending(b => b.UserName) : query.OrderBy(b => b.UserName),
                "createdat" => isDesending ? query.OrderByDescending(b => b.CreatedAt) : query.OrderBy(b => b.CreatedAt),
                "city" => isDesending ? query.OrderByDescending(b => b.City) : query.OrderBy(b => b.City),
                "age" => isDesending ? query.OrderByDescending(b => b.Age) : query.OrderBy(b => b.Age),
                "address" => isDesending ? query.OrderByDescending(b => b.Address) : query.OrderBy(b => b.Address),
                "email" => isDesending ? query.OrderByDescending(b => b.Email) : query.OrderBy(b => b.Email),
                "firstname" => isDesending ? query.OrderByDescending(b => b.Firstname) : query.OrderBy(b => b.Firstname),
                "lastname" => isDesending ? query.OrderByDescending(b => b.Lastname) : query.OrderBy(b => b.Lastname),
                "displayname" => isDesending ? query.OrderByDescending(b => b.Displayname) : query.OrderBy(b => b.Displayname),
                "dateofbirth" => isDesending ? query.OrderByDescending(b => b.DateOfBirth) : query.OrderBy(b => b.DateOfBirth),
                _ => query.OrderBy(b => b.Id),
            };

            return query;
        }
    }
}
