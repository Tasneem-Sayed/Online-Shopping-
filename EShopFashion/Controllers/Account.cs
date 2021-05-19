using EShopFashion.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopFashion.Controllers
{
    public class Account : Controller
    {
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model) 
        {
            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
