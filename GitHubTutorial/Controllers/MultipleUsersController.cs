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

            //In master, someone else had made changes different from the ones you made.
            //var x = 1;
            //var y = 50;
            var x =981;
            var y = 9920;
            var a = 12445;
            return View();
        }
    }
}