using Microsoft.AspNetCore.Mvc;

namespace Project_AdminPanel_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
