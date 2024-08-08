namespace HomeDecorAPI.Presentation.Extensions {
    public static class ServiceExtensions {
        // Connect Database 
        public static void ConfigureSQLServerContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("ApplicationConnection")));

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

    }
}
