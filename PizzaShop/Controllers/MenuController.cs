using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaShop.Models;

namespace PizzaShop.Controllers
{
    public class MenuController : Controller
    {
        private IProductRepository repository;
        public MenuController(IProductRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(Product products)
        {
            return View();
        }
    }
}