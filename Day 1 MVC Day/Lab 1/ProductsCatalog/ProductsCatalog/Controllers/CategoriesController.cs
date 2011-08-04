using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductsCatalog.Models;

namespace ProductsCatalog.Controllers
{   
    public class CategoriesController : Controller
    {
		private readonly ICategoriesRepository categoriesRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public CategoriesController() : this(new CategoryRepository())
        {
        }

        public CategoriesController(ICategoriesRepository categoriesRepository)
        {
			this.categoriesRepository = categoriesRepository;
        }

        //
        // GET: /Categories/

        public ViewResult Index()
        {
            return View(categoriesRepository.All);
        }

        //
        // GET: /Categories/Details/5

        public ViewResult Details(int id)
        {
            return View(categoriesRepository.Find(id));
        }

        //
        // GET: /Categories/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Categories/Create

        [HttpPost]
        public ActionResult Create(Category categories)
        {
            if (ModelState.IsValid) {
                categoriesRepository.InsertOrUpdate(categories);
                categoriesRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Categories/Edit/5
 
        public ActionResult Edit(int id)
        {
             return View(categoriesRepository.Find(id));
        }

        //
        // POST: /Categories/Edit/5

        [HttpPost]
        public ActionResult Edit(Category categories)
        {
            if (ModelState.IsValid) {
                categoriesRepository.InsertOrUpdate(categories);
                categoriesRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Categories/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(categoriesRepository.Find(id));
        }

        //
        // POST: /Categories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            categoriesRepository.Delete(id);
            categoriesRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

