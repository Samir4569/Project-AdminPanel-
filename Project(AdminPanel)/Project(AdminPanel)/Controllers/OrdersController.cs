using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_AdminPanel_.DAL;
using Project_AdminPanel_.Helpers;
using Project_AdminPanel_.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project_AdminPanel_.Controllers
{
    public class OrdersController : Controller
    {
        private AppDbContext _db;
        private readonly IWebHostEnvironment _env;

        public OrdersController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public async Task <IActionResult> Index()
        {
            List<Order> orders = await _db.Orders.ToListAsync();

            return View(orders);
        }


        #region Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Order Order)
        {
            if (Order.Photo == null)
            {
                ModelState.AddModelError("Photo", "please select image file");
                return View();
            }
            if (!Order.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "please select image file");
                return View();
            }
            if (!Order.Photo.IsBigger2MB())
            {
                ModelState.AddModelError("Photo", "is it bigger than two mb? if not, please select bigger one");
                return View();
            }

            string folder = Path.Combine(_env.WebRootPath, "img", "Order");
            Order.Image = await Order.Photo.SaveImageAsync(folder);
            await _db.Orders.AddAsync(Order);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");

        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                NotFound();
            }
            Order orders = await _db.Orders.FirstOrDefaultAsync(x => x.Id == id);
            if (orders == null)
            {
                return BadRequest();
            }
            return View(orders);
        }

        #endregion

        #region Activity
        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order dbOrders = await _db.Orders.FirstOrDefaultAsync(x => x.Id == id);
            if (dbOrders == null)
            {
                return BadRequest();
            }

            if (dbOrders.IsAproved)
            {
                dbOrders.IsAproved = false;
            }
            else
            {
                dbOrders.IsAproved = true;
            }


            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

    }
}
