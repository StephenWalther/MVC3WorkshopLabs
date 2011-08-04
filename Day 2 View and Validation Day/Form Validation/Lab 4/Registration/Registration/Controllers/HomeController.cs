using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid) {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult ValidateLastName(string lastName) {
            var result = (lastName.Equals("Smith") || lastName.Equals("Jones") || lastName.Equals("Williams"));
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
