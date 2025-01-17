using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LabHelloMvc.Models;

namespace LabHelloMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //create person object
        Person person1 = new Person()
        {
            personId = 1,
            FirstName = "John",
            LastName = "Doe"
        };
        
        return View(person1);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}