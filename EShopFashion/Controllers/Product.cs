﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopFashion.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
