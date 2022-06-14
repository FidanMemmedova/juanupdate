﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Juan.DAL;
using Juan.Helpers;
using Juan.Models;

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slide slide)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!slide.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Max size image must be less than 200kb");
                return View();
            }
            if (!slide.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of file must be image");
                return View();
            }
            //return Json(slide.Photo.ContentType.Contains("image/"));
            //return Json("Ok");

            slide.Image = await slide.Photo.SaveFileAsync(_env.WebRootPath, "assets", "img", "slider");
            await _context.Slides.AddAsync(slide);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var slider = _context.Slides.Find(id);
            if (slider == null)
            {
                return NotFound();
            }
            var path = Helper.GetPath(_env.WebRootPath, "assets","img","slider", slider.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Slides.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var slide = _context.Slides.Find(id);
            if (slide == null)
            {
                return NotFound();
            }
            return View(slide);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Slide slide)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var slider = _context.Slides.Find(slide.Id);
            if (slider == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!slide.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Max size image must be less than 200kb");
                return View();
            }
            if (!slide.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of file must be image");
                return View();
            }
            var path = Helper.GetPath(_env.WebRootPath, "assets", "img", "slider", slider.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            slider.Image = await slide.Photo.SaveFileAsync(_env.WebRootPath, "assets", "img", "slider");
            //slider.Tile = slide.Tile;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
