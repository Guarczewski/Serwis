using Microsoft.AspNetCore.Mvc;

namespace Serwis.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
