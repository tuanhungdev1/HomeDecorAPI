using HomeDecorAPI.Application.Shared.ErrorModel;
using HomeDecorAPI.Domain.Exceptions.BadRequestException;
using HomeDecorAPI.Domain.Exceptions.ForbiddenException;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using HomeDecorAPI.Domain.Exceptions.UnauthorizedException;
using Microsoft.AspNetCore.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;

namespace HomeDecorAPI.Presentation.Extensions {
    public static class ExceptionMiddlewareExtensions {
        public static void ConfigureExceptionHandler(this WebApplication app) {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null) {
                        context.Response.StatusCode = contextFeature.Error switch {
                            NotFoundException => StatusCodes.Status404NotFound,
                            BadRequestException => StatusCodes.Status400BadRequest,
                            UnauthorizedException => StatusCodes.Status401Unauthorized,
                            ForbiddenException => StatusCodes.Status403Forbidden,
                            _ => StatusCodes.Status500InternalServerError
                        };

                        await context.Response.WriteAsync(new ErrorDetails() {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error.Message,
                        }.ToString());
                    }
                });
            });
        }
    }

}
