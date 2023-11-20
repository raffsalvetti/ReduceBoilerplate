using Microsoft.Extensions.DependencyInjection;

namespace Commons.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection RegisterSwaggerServices(this IServiceCollection services)
    {
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}