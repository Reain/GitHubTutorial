using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubTutorial.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public class ThisIsSomethingThatIsEdited {
            //Here for our example is a class that is going to be edited. This is master.
        }

        public class StuffThatIsAddedFromOtherUsers {

        }

    }
}