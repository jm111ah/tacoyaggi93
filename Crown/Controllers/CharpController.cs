﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crown.Controllers
{
    public class CharpController : Controller
    {
        public IActionResult Charp()
        {
            return View();
        }

        public IActionResult NLog()
        {
            return View();
        }
    }
}
