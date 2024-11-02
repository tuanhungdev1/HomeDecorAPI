using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;

public class TokenValidationMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<TokenValidationMiddleware> _logger;

    public TokenValidationMiddleware(RequestDelegate next, ILogger<TokenValidationMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        var endpoint = context.GetEndpoint();

        // Nếu không tìm thấy endpoint, cho phép request đi tiếp
        if (endpoint == null)
        {
            await _next(context);
            return;
        }

        // Kiểm tra xem endpoint có yêu cầu Authorize không
        var authorizeAttribute = endpoint.Metadata.GetMetadata<AuthorizeAttribute>();

        // Nếu endpoint không có Authorize attribute, cho phép request đi tiếp
        if (authorizeAttribute == null)
        {
            await _next(context);
            return;
        }

        // Lấy token từ header
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

        // Nếu không có token cho endpoint yêu cầu xác thực
        if (token == null)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsJsonAsync(new
            {
                success = false,
                message = "Không tìm thấy token xác thực",
                statusCode = 401
            });
            return;
        }

        // Kiểm tra token
        try
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

            if (jsonToken != null)
            {
                var now = DateTimeOffset.Now;
                _logger.LogInformation($"Current time (local): {now}");
                _logger.LogInformation($"Current time (UTC): {now.UtcDateTime}");
                _logger.LogInformation($"Token expires at: {jsonToken.ValidTo}");

                // Kiểm tra token hết hạn
                if (jsonToken.ValidTo < now.UtcDateTime)
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsJsonAsync(new
                    {
                        success = false,
                        message = "Token has expired",
                        statusCode = 401
                    });
                    return;
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Token validation error: {ex.Message}");
            context.Response.StatusCode = 401;
            await context.Response.WriteAsJsonAsync(new
            {
                success = false,
                message = "Invalid token",
                statusCode = 401
            });
            return;
        }

        await _next(context);
    }
}