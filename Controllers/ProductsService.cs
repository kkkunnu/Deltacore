using Deltacore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deltacore.Controllers
{
    public class ProductsService
    {
        public List<Product> GetProducts()
        {
            // Sample data
            return new List<Product>
    {
        new Product { Id = 1001, Name = "Tools Gears", Description = "Gear tools production specification" },
        new Product { Id = 2001, Name = "Panels Switch", Description = "Gear Panels" },
        new Product { Id = 2008, Name = "DocTonar Document", Description = "Solar Objects" }
    };
        }
    }
}