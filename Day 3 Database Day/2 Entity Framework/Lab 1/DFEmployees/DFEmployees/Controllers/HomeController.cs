using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DFEmployees.Models;

namespace DFEmployees.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        EmployeesDB context = new EmployeesDB();

        public ActionResult Index()
        {
            return View(context.Employees);
        }

    }
}
