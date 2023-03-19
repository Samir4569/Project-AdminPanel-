using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_AdminPanel_.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project_AdminPanel_.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

      
        public IActionResult Error()
        {
            return View();
        }
    }
}
