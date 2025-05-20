namespace asp_practice_api.Startup;
using Scalar.AspNetCore;

public static class DependenciesConfig
{
    public static void AddDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApiServices();
        
        
    }
}