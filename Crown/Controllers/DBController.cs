using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crown.Controllers
{
    public class DBController : Controller
    {
        public IActionResult Trigger()
        {
            return View();
        }
    }
}
