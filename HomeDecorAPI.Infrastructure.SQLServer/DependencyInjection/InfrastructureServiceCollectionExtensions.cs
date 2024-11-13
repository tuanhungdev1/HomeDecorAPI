using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Services;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using HomeDecorAPI.Infrastructure.SQLServer.Persistence;
using HomeDecorAPI.Infrastructure.SQLServer.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.DependencyInjection {
    public static class InfrastructureServiceCollectionExtensions {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration) {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ApplicationConnection"))
            );

            // Đăng Kí Repository
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IWishlistRepository, WishlistRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            

            //Đăng Kí Unit Of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            return services;
        }
    }
}
