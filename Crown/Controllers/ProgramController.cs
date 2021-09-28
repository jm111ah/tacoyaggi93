using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crown.Controllers
{
    public class ProgramController : Controller
    {
        public IActionResult Charp()
        {
            return View();
        }

        public IActionResult Core()
        {
            return View();
        }
    }
}
