﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Areas.AdminPanel.Controllers
{
    public class SlideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
