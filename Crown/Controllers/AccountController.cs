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
                 dbc.Select(String.Format("select * from member where Id = '{0}' and Name = '{1}' ", Info.Email, Info.Pass));
                if (vm.Viewmodel_ds != null)
                {
                    return RedirectToAction("Home/Index");
                }
            }
            return View(vm.ErrorMessage);
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(SignUp Info)
        {
            dbc.Insert(String.Format("insert into Member(Email,Name,Pass) values('{0}','{1}','{2}')" , Info.Email , Info.Name , Info.Password));
            if (string.IsNullOrEmpty(vm.ErrorMessage))
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View(vm.ErrorMessage);
            }
        }
    }
}
