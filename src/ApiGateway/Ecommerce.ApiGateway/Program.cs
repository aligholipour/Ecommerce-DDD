using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.SetBasePath(builder.Environment.ContentRootPath);
builder.Configuration.AddJsonFile("appsettings.json", false, true);
builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", false, true);
builder.Configuration.AddJsonFile("ocelot.json", false, true);
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddOcelot(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();

app.UseOcelot().Wait();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
