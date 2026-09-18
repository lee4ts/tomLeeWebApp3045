
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TomLeeWebApp3045.Models;
using TomLeeWebApp3045.Data;
using TomLeeWebApp3045.Interfaces;

    var builder = WebApplication.CreateBuilder(args);

// Inject dependencies prior to build
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BLibContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BLibContext")));

builder.Services.AddScoped<IBLibContextDAO, BLibContextDAO>();

var app = builder.Build();

app.Services.GetRequiredService<BLibContext>().Database.Migrate();

app.UseRouting();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();



