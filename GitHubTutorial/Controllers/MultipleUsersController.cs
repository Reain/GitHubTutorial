using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubTutorial.Controllers
{
    public class MultipleUsersController : Controller
    {
        // GET: MultipleUsers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WhatTheTeamIsWorkingOn() {
            var x = 1;
            var y = 50;
            return View();
        }
    }
}