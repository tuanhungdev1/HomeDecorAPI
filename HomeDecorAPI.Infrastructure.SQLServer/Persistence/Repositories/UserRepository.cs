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
        }
    }
}
