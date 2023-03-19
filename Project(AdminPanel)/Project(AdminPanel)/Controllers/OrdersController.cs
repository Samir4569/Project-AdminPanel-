using Microsoft.AspNetCore.Mvc;

namespace Project_AdminPanel_.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
