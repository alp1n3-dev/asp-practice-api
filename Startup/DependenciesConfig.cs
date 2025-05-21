namespace asp_practice_api.Startup;
using Scalar.AspNetCore;
using asp_practice_api.Data;

public static class DependenciesConfig
{
    public static void AddDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApiServices();
        builder.Services.AddTransient<CourseData>();

    }
}