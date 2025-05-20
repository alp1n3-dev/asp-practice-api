using Scalar.AspNetCore;
using asp_practice_api.Startup;
using asp_practice_api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddOpenApiServices(); // need this one to work
builder.AddDependencies();
//builder.Services.AddOpenApiServices();

var app = builder.Build();

app.UseOpenApi();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{

});

app.Run();


