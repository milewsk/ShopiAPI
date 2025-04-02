using Serilog;

namespace Shopi.API.Configuration;

public static class LoggerConfiguration
{
    public static void  CreateLogger( WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog((context, loggerConfig) =>
        {
            loggerConfig.ReadFrom.Configuration(context.Configuration);
        });
    }
}