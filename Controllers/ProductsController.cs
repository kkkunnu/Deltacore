using Deltacore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deltacore.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ProductsController
        public ActionResult Index()
        {
            
            var productService = new ProductsService();
            List<Product> products = productService.GetProducts();

            return View(products);
        }
    }
}