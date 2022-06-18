using Juan.DAL;
using Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Controllers
{
    public class ShopController : Controller
    {
        private AppDbContext _context { get; }
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ShopViewModel shop = new ShopViewModel
            {
                ShopProducts = _context.ShopProducts.ToList()
            };
            return View(shop);
        }
    }
}
