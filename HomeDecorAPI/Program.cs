using HomeDecorAPI.Application.MappingProfile;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MappingProfile));

//Extensions
builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureCors();
builder.Services.ConfigureSQLServerContext(builder.Configuration);
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureJWT(builder.Configuration);
builder.Services.ConfigureJsonSerializerSettings();

//Action Filters
builder.Services.AddScoped<ValidationFilterAttribute>();


var app = builder.Build();

// Extensions
app.ConfigureExceptionHandler();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
