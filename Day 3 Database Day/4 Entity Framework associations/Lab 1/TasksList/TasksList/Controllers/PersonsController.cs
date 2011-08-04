using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasksList.Models;

namespace TasksList.Controllers
{
    public class PersonsController : Controller
    {
        TasksListDB context = new TasksListDB();
        //
        // GET: /Persons/

        public ActionResult Index()
        {
            return View(context.Persons);
        }

        public ActionResult TasksList(int PersonId)
        {
            var tasks = context.Tasks.Where(t => t.Person.Id == PersonId);

            return View(tasks);
        }
    }
}
