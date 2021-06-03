using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Swa.Controllers
{
    public class swaController : Controller
    {
        // GET: swa
        public ActionResult Index()
        {
            return View("v");// create view here
        }
    }
}