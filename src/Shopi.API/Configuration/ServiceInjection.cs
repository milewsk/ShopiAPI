namespace Shopi.API.Configuration;

public static class ServiceInjection
{
    public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }

    public static IApplicationBuilder UseConfiguration(this IApplicationBuilder app)
    {
        return app;
    }

    public static IServiceCollection AddCaching(IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }

    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}