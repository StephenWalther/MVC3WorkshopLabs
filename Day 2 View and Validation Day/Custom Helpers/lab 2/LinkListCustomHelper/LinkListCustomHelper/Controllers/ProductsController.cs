using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkListCustomHelper.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductsController : Controller
    {
        IList<Product> productList = null;

        public ProductsController()
        {
            var products = new List<Product> {
                new Product {Id=1,Name="Milk",Price=1.99m},
                new Product {Id=1,Name="Bread",Price=3.00m},
                new Product {Id=1,Name="Steak",Price=12.00m}
            };

            productList = products;
        }

        //
        // GET: /Products/      

        public ActionResult Index()
        {
            return View(productList);
        }

        public ActionResult Product(Int32 Id) {

            var product = productList.Where(p => p.Id == Id).FirstOrDefault();
            return View(product);
        }
    }   
}
