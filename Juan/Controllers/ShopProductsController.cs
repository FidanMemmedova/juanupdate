using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Juan.DAL;
using Juan.Models;

namespace Juan.Controllers
{
    public class ShopProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ShopProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ShopProducts
        public IActionResult Index(int pageNumber=1,int pageSize=1)
        {
            int ExcludeRecords = (pageSize * pageNumber) - pageSize;
            var ShopProducts= _context.ShopProducts.OrderByDescending(p => p.Id).Skip(ExcludeRecords).Take(pageSize).ToList();
            return View(ShopProducts);
        }

        // GET: ShopProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopProduct = await _context.ShopProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shopProduct == null)
            {
                return NotFound();
            }

            return View(shopProduct);
        }

        // GET: ShopProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShopProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image,ProductName,Price,Discount")] ShopProduct shopProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shopProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shopProduct);
        }

        // GET: ShopProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopProduct = await _context.ShopProducts.FindAsync(id);
            if (shopProduct == null)
            {
                return NotFound();
            }
            return View(shopProduct);
        }

        // POST: ShopProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,ProductName,Price,Discount")] ShopProduct shopProduct)
        {
            if (id != shopProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shopProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopProductExists(shopProduct.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(shopProduct);
        }

        // GET: ShopProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopProduct = await _context.ShopProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shopProduct == null)
            {
                return NotFound();
            }

            return View(shopProduct);
        }

        // POST: ShopProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shopProduct = await _context.ShopProducts.FindAsync(id);
            _context.ShopProducts.Remove(shopProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopProductExists(int id)
        {
            return _context.ShopProducts.Any(e => e.Id == id);
        }
    }
}
