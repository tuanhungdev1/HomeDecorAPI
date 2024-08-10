﻿using HomeDecorAPI.Application.Shared.DTOs.TokenDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface IAuthenticationService {
        Task<IdentityResult> RegisterUserAsync(UserForRegistrationDto userForRegistration);
        Task<User?> LoginAsync(UserForLoginDto userForLoginDto);
        Task<TokenDto> CreateToken(bool populateExp);
    }
}
