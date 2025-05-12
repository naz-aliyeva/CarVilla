using Microsoft.AspNetCore.Mvc;

namespace CarVilla.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
