using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace HomeDecorAPI.Presentation.Middleware
{
    public class TokenValidationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        public TokenValidationMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                var tokenHandler = new JwtSecurityTokenHandler();

                try
                {
                    var jwtToken = tokenHandler.ReadJwtToken(token);

                    if (jwtToken.ValidTo < DateTime.UtcNow)
                    {
                        // Ensure response hasn't started
                        if (!context.Response.HasStarted)
                        {
                            context.Response.Clear();
                            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                            context.Response.ContentType = "application/json";

                            var response = new
                            {
                                status = 401,
                                message = "TokenExpireError",
                                timestamp = DateTime.UtcNow
                            };

                            await context.Response.WriteAsJsonAsync(response);
                        }
                        return;
                    }

                    // Validate token
                    var tokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = _configuration["JwtSettings:ValidIssuer"],
                        ValidAudience = _configuration["JwtSettings:ValidAudience"],
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecurityKey"]))
                    };

                    var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out _);
                }
                catch (SecurityTokenExpiredException)
                {
                    if (!context.Response.HasStarted)
                    {
                        context.Response.Clear();
                        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        context.Response.ContentType = "application/json";

                        var response = new
                        {
                            status = 401,
                            message = "TokenExpireError",
                            timestamp = DateTime.UtcNow
                        };

                        await context.Response.WriteAsJsonAsync(response);
                    }
                    return;
                }
            }

            await _next(context);
        }
    }
}
