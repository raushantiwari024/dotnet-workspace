using Microsoft.AspNetCore.Mvc;

namespace ViewAndLayout.Controllers
{
    [Route("[controller]")]
    [Route("")]
    public class HomeController : Controller
    {
        [Route("[action]")]
        [Route("")]
        public IActionResult Index(){
            ViewData["name"] = "Raushan";
            ViewData["number"]= 9608411621;
            ViewData["email"] = "raushantiwari5566@gmail.com";
            return View();
        }

        [Route("[action]")]
        public IActionResult About(){
            return View();
        }
    }
}