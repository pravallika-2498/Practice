using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Swa.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {

            
                return View("Register");
            
         }
        [HttpPost]
        public ActionResult Index(Register r)
        {
            return View();
        }


    }
}