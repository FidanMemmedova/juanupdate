using Juan.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SlideController : Controller
    { 
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public SlideController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Slides);
        } 
        public IActionResult Create()
        {
            return View();
        }

        
    }
}
