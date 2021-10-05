using Crown.Lib;
using Crown.Models;
using Crown.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Crown.Controllers
{
    public class AccountController : Controller
    {
        DBConnection dbc = new DBConnection();
        Viewmodel_Login vm = new Viewmodel_Login();
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Login Info)
        {
            if (ModelState.IsValid)
            {
                 dbc.Select("");
               var test = vm.Viewmodel_ds;
            }
            return View(Info);
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(SignUp Info)
        {
            return View();
        }
    }
}
