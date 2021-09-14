using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRG522_SA_7285.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Services
        public ActionResult Services()
        {
            return View();
        }
        // GET: Portfolio
        [Authorize]
        public ActionResult Portfolio()
        {
            return View();
        }
        // GET: About
        public ActionResult About()
        {
            return View();
        }
        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }
        // GET: Error
        public ActionResult Error()
        {
            return View();
        }
    }
}