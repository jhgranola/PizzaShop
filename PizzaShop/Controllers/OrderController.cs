using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzaShop.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Completed()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}