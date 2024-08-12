using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services {
    public sealed class ServiceManager : IServiceManager {

        private readonly Lazy<IAuthenticationService> _authenticationService;
        private readonly Lazy<IUserService> _userService;

        public ServiceManager(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration) {
            _authenticationService = new Lazy<IAuthenticationService>(() =>
             new AuthenticationService(mapper, userManager, signInManager, configuration));

            _userService = new Lazy<IUserService>(() => new UserService(userManager, mapper));
        }
        public IAuthenticationService AuthenticationService =>
       _authenticationService.Value;

        public IUserService UserService => _userService.Value;
    }
}
