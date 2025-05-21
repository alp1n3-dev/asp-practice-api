using Scalar.AspNetCore;
using asp_practice_api.Startup;
using asp_practice_api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.AddDependencies();

var app = builder.Build();
app.UseOpenApi();
app.UseHttpsRedirection();

app.AddRouteEndpoints();
app.AddCourseEndpoints();

app.Run();


