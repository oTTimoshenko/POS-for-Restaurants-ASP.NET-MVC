using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POSforRestaurants.WebUI.Controllers
{
    public class WaiterController : Controller
    {
        // GET: Waiter
        public ActionResult Index()
        {
            return View();
        }
    }
}