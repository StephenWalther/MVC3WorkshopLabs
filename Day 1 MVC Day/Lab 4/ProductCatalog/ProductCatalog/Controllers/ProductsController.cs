using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductCatalog.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public string List(int pagenumber, string category)
        {
            return "Page number is " + pagenumber.ToString() + " Category = " + category;
        }
    }
}
