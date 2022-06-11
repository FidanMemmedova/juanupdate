using Juan.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Areas.AdminPanel.Controllers
{
    public class SlideController : Controller
    { 
        [Area("AdminPanel")]
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
