using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace PizzaShop.Controllers
{
    public class OrderController : Controller
    {
        //private IOrderRepository repository;
        private PizzaShopDbContext context;

        public OrderController(PizzaShopDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult List()
        {
            return View(context.Orders.Where(o => !o.Completed));
        }

        [HttpPost]
        public IActionResult MarkCompleted(int orderID)
        {
            Order order = context.Orders.FirstOrDefault(o => o.OrderID == orderID);
            if (order != null)
            {
                order.Completed = true;
                context.SaveChanges();
            }
            return RedirectToAction(nameof(List));
        }

        [HttpPost]
        public IActionResult MarkDelivered(int orderID)
        {
            Order order = context.Orders.FirstOrDefault(o => o.OrderID == orderID);
            if (order != null)
            {
                order.Delivered = true;
                context.SaveChanges();
            }
            return RedirectToAction(nameof(List));
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