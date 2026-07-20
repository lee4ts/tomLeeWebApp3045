
using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Inject dependencies prior to build
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();



