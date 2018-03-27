using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCControllerDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "This is Home Controller";
        }

        // GET: Home
        public ActionResult Index1()
        {
            return RedirectToAction("GetAllCustomers", "Customer");
        }


    }
}