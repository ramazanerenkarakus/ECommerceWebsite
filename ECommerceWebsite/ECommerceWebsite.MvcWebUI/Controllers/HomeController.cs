using ECommerceWebsite.MvcWebUI.Entity;
using ECommerceWebsite.MvcWebUI.Models;
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
            var products = _context.Products.Where(i => i.IsHome && i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                ProductName = i.ProductName,
                ProductDescription = i.ProductDescription.Length > 50 ? i.ProductDescription.Substring(0, 47) + "..." : i.ProductDescription,
                ProductPrice = i.ProductPrice,
                ProductStock = i.ProductStock,
                Image = i.Image,
                CategoryId = i.CategoryId
            }).ToList();

            return View(products);
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }

        public ActionResult List()
        {
            var products = _context.Products.Where(i => i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                ProductName = i.ProductName,
                ProductDescription = i.ProductDescription.Length > 50 ? i.ProductDescription.Substring(0, 47) + "..." : i.ProductDescription,
                ProductPrice = i.ProductPrice,
                ProductStock = i.ProductStock,
                Image = i.Image ?? "samsunTelefon.jpg",
                CategoryId = i.CategoryId
            }).ToList();

            return View(products);
        }
    }
}