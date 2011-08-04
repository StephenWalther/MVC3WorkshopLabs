using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalcCustomHelper.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculator/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }      

        [HttpPost]
        public ActionResult Add(FormCollection formCollection)
        {
            Int32 Number1 = Convert.ToInt32(formCollection["Number1"]);
            Int32 Number2 = Convert.ToInt32(formCollection["Number2"]);
            Int32 Sum = Number1 + Number2;

            return View("Result", Sum);
        }      
    }
}
