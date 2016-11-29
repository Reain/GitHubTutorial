using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubTutorial.Controllers
{
    public class ChangingTheName : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public class ThisIsSomethingThatIsEdited {
            //Here for our example is a class that is going to be edited. This is master I'm going to make changes 
            //here.
        }
        public class MybranchThatImAdding {
            //My additions to my branch that will go to master.
        }

        public class StuffThatIsAddedFromOtherUsers {

        }

    }
}