using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReleaseIt.Web.Client.Controllers
{
    /// <summary>
    /// The default MVC controller for our Index.cshtml page
    /// </summary>
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            //lets return our index.cshtml as a response - this is the only page we are returing.
            return View("~/Views/Index.cshtml"); //specify the Index location since its directly under the Views folder.
        }
    }
}
