using EShopFashion.Models;
using EShopFashion.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopFashion.Controllers
{
   
    public class FashionEcommerce : Controller
    {
        ArrivalsAreaServices ArrivalsAreaServices = new ArrivalsAreaServices();
        public IActionResult Index()
        {
            var products = ArrivalsAreaServices.GetArrivalsAreas();
            return View(products);
        }
    }
}
