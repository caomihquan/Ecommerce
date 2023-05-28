using Ecore;
using EServices.Products;
using EServices.Token;
using EServices.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var env = builder.Environment.EnvironmentName;
var isDevelopment = builder.Environment.IsDevelopment();

builder.Configuration
    .AddJsonFile("appsettings.json");

var connectionString = builder.Configuration.GetConnectionString("TenantConnection") ?? "";

builder.Services
    .AddInternalServices(builder.Configuration)
    .AddCoreService(connectionString, isDevelopment, isDevelopment)
    .AddUserService()
    .AddProductService();

builder.Services.AddControllersWithViews();
builder.Services.AddJwtAuthentication(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
