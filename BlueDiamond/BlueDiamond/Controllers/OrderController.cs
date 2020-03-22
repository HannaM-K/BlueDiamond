using BlueDiamond.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Index()
        {
            return View(new Order());
        }

        [HttpPost]
        public IActionResult Index(Order order)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("OrderCompleted");
                //return RedirectToAction("List", "Product", new { categoryName = string.Empty});
            }
            else
            {
                return View(order);
            }
        }

        public ViewResult OrderCompleted()
        {
            return View();
        }
    }
}
