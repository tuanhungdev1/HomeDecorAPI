using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Persistence.Repositories {
    public class UserRepository : RepositoryBase<User>, IUserRepository {
        private readonly ApplicationDbContext _context;
        
        public UserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User?> GetUserImageAsync(string userId) {
            var user = await _context.Users
                .Include(u => u.UserImage)
                .FirstOrDefaultAsync(u => u.Id == userId);

            return user;
        }

        public async Task<User?> GetUserByIdAsync(string userId) {
            var user = await _context.Users
                .Include(u => u.UserImage)
                .FirstOrDefaultAsync(u => u.Id == userId);

            return user;
        }
    }
}
