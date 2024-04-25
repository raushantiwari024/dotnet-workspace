using Microsoft.AspNetCore.Mvc;

namespace ViewImportsTest.Controllers
{
    class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}