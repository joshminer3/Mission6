using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private ContextClass blahContext { get; set; }


    public HomeController(ILogger<HomeController> logger, ContextClass someName)
    {
        _logger = logger;
        blahContext = someName;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Podcast()
    {
        return View("Podcast");
    }

    [HttpGet]
    public IActionResult Movies()
    {
        return View("Movies");
    }

    [HttpPost]
    public IActionResult Movies(MovieForm ar)
    {
        blahContext.Add(ar);
        blahContext.SaveChanges();

        return View("Confirm");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

