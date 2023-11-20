using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace Commons.Extensions;

public static class WebApplicationExtensions
{
    public static WebApplication ConfigureSwaggerPipeline(this WebApplication webApp)
    {
        // Configure the HTTP request pipeline.
        if (webApp.Environment.IsDevelopment())
        {
            webApp.UseSwagger();
            webApp.UseSwaggerUI();
        }
        return webApp;
    }
}