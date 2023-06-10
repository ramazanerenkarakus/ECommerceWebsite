using ECommerceWebsite.MvcWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceWebsite.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        Context _context = new Context();
         
        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Products.ToList());
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
    }
}