namespace asp_practice_api.Endpoints;

public static class RootEndpoints
{
    public static void AddRouteEndpoints(this WebApplication app)
    {
        app.MapGet("/", () => "Hello World!");
    }
}