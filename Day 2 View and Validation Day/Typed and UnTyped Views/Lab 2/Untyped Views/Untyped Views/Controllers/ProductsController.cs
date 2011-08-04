using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Untyped_Views.Models;

namespace Untyped_Views.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product{ProductId= 1, Name="Product 1" , Price = 20M},
                new Product{ProductId= 2, Name="Product 2" , Price = 21M},
                new Product{ProductId= 3, Name="Product 3" , Price = 22M},
            };

            var categories = new List<Category>()
            {
                new Category{ CategoryId = 1, Name = "Category 1"},
                new Category{ CategoryId = 2, Name = "Category 2"},
                new Category{ CategoryId = 3, Name = "Category 3"}
            };

            ViewData["Products"] = products;
            ViewBag.Categories = categories;

            return View();          
        }


        public ActionResult Details() {

            var products = new List<Product>()
            {
                new Product{ProductId= 1, Name="Product 1" , Price = 20M},
                new Product{ProductId= 2, Name="Product 2" , Price = 21M},
                new Product{ProductId= 3, Name="Product 3" , Price = 22M},
            };

            var categories = new List<Category>()
            {
                new Category{ CategoryId = 1, Name = "Category 1"},
                new Category{ CategoryId = 2, Name = "Category 2"},
                new Category{ CategoryId = 3, Name = "Category 3"}
            };

            var vm = new ProductDetailsViewModel();
            vm.Products = products;
            vm.Categories = categories;

            return View(vm);
        }
    }
}
