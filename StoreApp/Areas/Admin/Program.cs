using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;
using Services.Contratc;
using StoreApp.Infrastructe.Extensions;
using StoreApp.Models;



var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.ConfigureSession();
builder.Services.ConfigureRepositoryRegistration();
builder.Services.ConfigureServiceRegistration();
builder.Services.ConfigureRouting();
builder.Services.ConfigureIdentity();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseSession();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.ConfigureLocalization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        
        name: "Admin",
        areaName: "Admin",
        pattern:"Admin/{controller=Dashboard}/{action=Index}/{id?}"

        );
    endpoints.MapControllerRoute(
            "default",
            "{controller=Home}/{action=Index}/{id?}"
        );
    endpoints.MapRazorPages();
});



app.ConfigureAndCheckMigration();
app.ConfigureDefaultAdminUser();
app.Run();
