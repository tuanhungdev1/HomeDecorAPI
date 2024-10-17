using HomeDecorAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Interfaces {
    public interface IUserRepository : IRepositoryBase<User> {
        Task<User?> GetUserImageAsync(string userId);
        Task<User?> GetUserByIdAsync(string userId);
    }
}
