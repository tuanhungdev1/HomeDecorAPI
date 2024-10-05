using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Services;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using HomeDecorAPI.Infrastructure.SQLServer.Persistence;
using HomeDecorAPI.Infrastructure.SQLServer.Persistence.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text;

namespace HomeDecorAPI.Presentation.Extensions
{
    public static class ServiceExtensions {
        // Create Policy Cors
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders("X-Pagination"));
            });

        // IIS
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options => {

            });


        //Identity
        public static void ConfigureIdentity(this IServiceCollection services) {
            var builder = services.AddIdentity<User, IdentityRole>(o => {
                o.Password.RequireDigit = true;
                o.Password.RequireLowercase = true;
                o.Password.RequireUppercase = true;
                o.Password.RequireNonAlphanumeric = true;
                o.Password.RequiredLength = 10;
                o.User.RequireUniqueEmail = true;
            })
             .AddEntityFrameworkStores<ApplicationDbContext>()
             .AddDefaultTokenProviders();
        }
            
        // JWT
        public static void ConfigureJWT(this IServiceCollection services, IConfiguration
configuration) {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var secretKey = jwtSettings["secretKey"];

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options => {
                options.TokenValidationParameters = new TokenValidationParameters {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = jwtSettings["validIssuer"],
                    ValidAudience = jwtSettings["validAudience"],
                    IssuerSigningKey = new
   SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
            });
        }

        public static void ConfigureJsonSerializerSettings(this IServiceCollection services) {
            services.AddControllers()
                .AddNewtonsoftJson(options => {
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                });
        }
    }
}
