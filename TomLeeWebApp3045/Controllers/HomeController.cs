using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using TomLeeWebApp3045.Models;

namespace TomLeeWebApp3045.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Name()
    {
        var personName = new Name { PersonName = "Tom Lee" };
        return View(personName);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
