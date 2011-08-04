using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeTemplates.Models;

namespace EmployeeTemplates.Controllers
{
    public class EmployeesController : Controller
    {
        //
        // GET: /Employees/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details() {

            var emp = new Employee {
              Id= 1,
               Name ="Stephen Walther" ,
                Phone = "1234595943"           
            };

            return View(emp);
        }

        public ActionResult Edit()
        {

            var emp = new Employee
            {
                Id = 1,
                Name = "Stephen Walther",
                Phone = "1234595943"
            };

            return View(emp);
        }
    }
}
