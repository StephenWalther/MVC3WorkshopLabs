using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerDatabase.Models;

namespace CustomerDatabase.Controllers
{
    public class CustomersController : Controller
    {
        //
        // GET: /Customers/

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customerToCreate)
        {            
            return View();
        }
    }
}
