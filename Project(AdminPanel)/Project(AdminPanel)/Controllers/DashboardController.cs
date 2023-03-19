using Microsoft.AspNetCore.Mvc;

namespace Project_AdminPanel_.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
