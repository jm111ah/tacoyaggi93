﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crown.Controllers
{
    public class ReactController : Controller
    {
        public IActionResult React()
        {
            return View();
        }
    }
}
