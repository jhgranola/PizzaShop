﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzaShop.Controllers
{
    public class FactoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}//test