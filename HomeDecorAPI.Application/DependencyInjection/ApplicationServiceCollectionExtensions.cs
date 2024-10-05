using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Services;
using HomeDecorAPI.Application.Shared.ActionFilters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DependencyInjection {
    public static class ApplicationServiceCollectionExtensions {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) {
            // Đăng ký Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();


            // Đăng ký AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Đăng ký Validators

            // Đăng ký Filter
            services.AddScoped<ValidationFilterAttribute>();

            return services;
        }
    }
}
