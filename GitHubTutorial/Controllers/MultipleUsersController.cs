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
            //var x = 1;
            //var y = 50;

            //For this example, the above values are in Master.
            //I'm changing it to below plus adding another variable.

            var x = 13;
            var y = 5213;
            var BranchAdded = 123;
            return View();
        }
    }
}