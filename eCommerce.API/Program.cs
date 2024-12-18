using eCommerce.Infrastructure;
using eCommerce.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure();
builder.Services.AddCore();

// Add controllers to the service collection
builder.Services.AddControllers();

// Build the web application
var app = builder.Build();

// Routing
app.UseRouting();

// Authentication and Authorization
app.UseAuthentication();
app.UseAuthorization();

// Controller routes
app.MapControllers();

app.Run();


