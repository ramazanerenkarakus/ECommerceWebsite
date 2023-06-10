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
            return View(_context.Products.Where(i => i.IsHome && i.IsApproved).ToList());
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).ToList());
        }

        public ActionResult List()
        {
            return View(_context.Products.Where(i => i.IsApproved).ToList());
        }
    }
}