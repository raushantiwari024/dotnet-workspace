using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TagHelperWithMvc.Models;
using System.Text.Json;

namespace TagHelperWithMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public string Index(Employee e)
    {
        // string json = JsonSerializer.Serialize(new {Name = e.Name,Gender = e.Gender,Age = e.Age, Designation = e.Designation, Salary = e.Salary,Description = e.Description});
        // Console.WriteLine(JsonSerializer.Serialize(e));
        return JsonSerializer.Serialize(e);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
