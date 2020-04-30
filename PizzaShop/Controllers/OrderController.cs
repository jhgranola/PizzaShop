using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzaShop.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;

        public OrderController(IOrderRepository repoService)
        {
            repository = repoService;
        }

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