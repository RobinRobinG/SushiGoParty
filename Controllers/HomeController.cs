using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SushiGo.Models;
using System.Linq;

namespace SushiGo.Controllers
{
    public class HomeController : Controller
    {
        private ProjectContext DbContext;
        public HomeController(ProjectContext context)
        {
            DbContext = context;
        }

        [HttpGet]
        [Route("home")]
        public IActionResult Home(LoginUser user)
        {
            if(!IsUserLoggedIn())
            {
                return RedirectToAction("Login", "LoginReg");
            }
            User CurrentUser = setCurrentUser();
            ViewBag.UserFirstName = CurrentUser.FirstName;
            ViewBag.UserId = CurrentUser.UserId;

            return View();
        }















        // genernal methods
        public bool IsUserLoggedIn()
        {
            if (HttpContext.Session.GetInt32("UserID") == null)
            {
                return false;
            }
            return true;
        }
        public User setCurrentUser()
        {
            User CurrentUser = DbContext.Users
                .SingleOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserID"));
            return CurrentUser;
        }
    }
}

