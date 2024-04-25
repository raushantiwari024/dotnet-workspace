using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using EmptyWeb.Models;

namespace EmptyWeb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // Console.Write(data);
        return View();
    }

    public IActionResult About()
    {
        // Console.Write(data);
        return View();
        // return data;
    }
}
