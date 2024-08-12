using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface IAdminService {
        Task<IdentityResult> CreateUserAsync(IdentityUser user);
    }
}
