using Lab23Again2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23Again2.Controllers
{
    public class ShopController2 : Controller
    {
        ShopContext db = new ShopContext();

        public IActionResult Index()
        {
            List<Products> product = db.Products.ToList();

            return View();
        }
    }
}
