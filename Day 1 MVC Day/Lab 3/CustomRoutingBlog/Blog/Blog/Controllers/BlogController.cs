using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/

        public ActionResult GetByDate(DateTime entryDate)
        {
            return View(entryDate);
        }

        public ActionResult GetById(int Id)
        {
            return View(Id);
        }

        public string  Default(string Id)
        {
            return "This is default:" + Id;
        }
    }
}
