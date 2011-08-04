using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;

namespace RandomNewsPartial.Controllers
{
    public class LatestNewsController : Controller
    {
        //
        // GET: /LatestNews/

        static Random rnd = new Random();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RandomNews() {
           
            ArrayList arrNews = new ArrayList();          
            arrNews.Add("Asp.net MVC3 Entity Framework 4.1 released");
            arrNews.Add("News 3 Code first allows you to Create database from model");
            arrNews.Add("We can install Entity Framework through NUget");
            int r = rnd.Next(arrNews.Count);            
            return PartialView("_News", arrNews[r].ToString());
        }

        

    }
}
