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

        public ServiceManager(IMapper mapper, UserManager<User> userManager, IConfiguration configuration) {
            _authenticationService = new Lazy<IAuthenticationService>(() =>
             new AuthenticationService(mapper, userManager,
          configuration));
        }
        public IAuthenticationService AuthenticationService =>
       _authenticationService.Value;
    }
}
