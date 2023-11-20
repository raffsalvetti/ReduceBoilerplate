using Commons.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Commons;

public static class Boot
{
    public static void Run(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.RegisterSwaggerServices();

        var app = builder.Build();

        app.ConfigureSwaggerPipeline();

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}