using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductsCatalog.Models;

namespace ProductsCatalog.Controllers
{   
    public class ProductsController : Controller
    {
		private readonly ICategoriesRepository categoriesRepository;
		private readonly IProductsRepository productsRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public ProductsController() : this(new CategoryRepository(), new ProductRepository())
        {
        }

        public ProductsController(ICategoriesRepository categoriesRepository, IProductsRepository productsRepository)
        {
			this.categoriesRepository = categoriesRepository;
			this.productsRepository = productsRepository;
        }

        //
        // GET: /Products/

        public ViewResult Index()
        {
            return View(productsRepository.All);
        }

        //
        // GET: /Products/Details/5

        public ViewResult Details(int id)
        {
            return View(productsRepository.Find(id));
        }

        //
        // GET: /Products/Create

        public ActionResult Create()
        {
			ViewBag.PossibleCategories = categoriesRepository.All;
            return View();
        } 

        //
        // POST: /Products/Create

        [HttpPost]
        public ActionResult Create(Product products)
        {
            if (ModelState.IsValid) {
                productsRepository.InsertOrUpdate(products);
                productsRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCategories = categoriesRepository.All;
				return View();
			}
        }
        
        //
        // GET: /Products/Edit/5
 
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleCategories = categoriesRepository.All;
             return View(productsRepository.Find(id));
        }

        //
        // POST: /Products/Edit/5

        [HttpPost]
        public ActionResult Edit(Product products)
        {
            if (ModelState.IsValid) {
                productsRepository.InsertOrUpdate(products);
                productsRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCategories = categoriesRepository.All;
				return View();
			}
        }

        //
        // GET: /Products/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(productsRepository.Find(id));
        }

        //
        // POST: /Products/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            productsRepository.Delete(id);
            productsRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

