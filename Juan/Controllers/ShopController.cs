using Juan.DAL;
using Juan.Models;
using Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList.Mvc;
using PagedList;

namespace Juan.Controllers
{
    public class ShopController : Controller
    {
        private AppDbContext _context { get; }
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page=1)
        {
            var query = _context.ShopProducts.ToList();
            const int pageSize = 12;
            if (page < 1)
            {
                page = 1;
            }
            int recsCount = query.Count();
            var pagination = new Pagination(recsCount, page, pageSize);

            int recSkip = (page - 1) * pageSize;
            var data = query.Skip(recSkip).Take(pagination.PageSize).ToList();
            this.ViewBag.Pagination = pagination;
            ShopViewModel shop = new ShopViewModel
            {
                ShopProducts = data
            };
            return View(shop);
        }
        public IActionResult Load()
        {
            List<ShopProduct> ShopProducts = _context.ShopProducts.OrderByDescending(p => p.Id).Skip(4).Take(4).ToList();
            return PartialView("_ProductPartial", ShopProducts);

        }
    }
}
