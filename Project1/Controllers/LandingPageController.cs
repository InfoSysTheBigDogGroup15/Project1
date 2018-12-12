﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Project1.Controllers
{
    public class LandingPageController : Controller
    {
        // GET: LandingPage
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(email, "greg@test.com") && (string.Equals(password, "Greg")))
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);

                return RedirectToAction("Index", "LandingPage");

            }
            else
            {
                return View();
            }
        }
    }
}