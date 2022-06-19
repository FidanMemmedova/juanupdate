﻿using Juan.DAL;
using Juan.Models;
using Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                ShopProducts = _context.ShopProducts.Skip(4).Take(4).ToList()
            };
            return View(shop);
        }
        public IActionResult Load()
        {
            List<ShopProduct> ShopProducts = _context.ShopProducts.OrderByDescending(p=>p.Id).Skip(4).Take(4).ToList();
            return PartialView("_ProductPartial",ShopProducts); 

        }
    }
}
