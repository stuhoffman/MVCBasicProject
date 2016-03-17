using MVCStarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStarter.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.SomeMessage = "This is a message from the controller";
            List<Product> products = new List<Product>();
            products.Add(new Product() { ProductId = 1, ProductName = "Product 1" });
            products.Add(new Product() { ProductId = 2, ProductName = "Product 2" });
            products.Add(new Product() { ProductId = 3, ProductName = "Product 3" });

            return View(products);
        }

        public ActionResult PartialProduct()
        {
            ViewBag.Message = "Partial Data";
            return View();
        }
        public ActionResult ProductDetails()
        {
            return View();
        }

    }
}