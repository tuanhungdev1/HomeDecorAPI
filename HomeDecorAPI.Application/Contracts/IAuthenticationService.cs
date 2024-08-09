using HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface IAuthenticationService {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
    }
}
