using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConventionalRoute.Controllers;

// [Route("Home")]
// [Route("[controller]/[action]")] // This is a way to specify token. here, Controller name replaced with controller token
// [Route("")]

// [Route("[controller]/[action]")]

[Route("[controller]")]
[Route("")]
public class HomeController : Controller
{

    // [Route("")]
    // // [Route("[action]")]//specifying token. Here, method name(Index) replaced with action token
    // [Route("~/")]
    // 
    [Route("[action]")]
    [Route("")]
    public IActionResult Index(){
        
        return View();
    }

    // // [Route("[action]/{id?}")]
    // [Route("{id?}")]

    [Route("[action]/{id?}")]
    public int Details(int id){
    // sadsdf
        return id;
    }

    [Route("[action]")]
    public IActionResult About(){
        return View();
    }
}