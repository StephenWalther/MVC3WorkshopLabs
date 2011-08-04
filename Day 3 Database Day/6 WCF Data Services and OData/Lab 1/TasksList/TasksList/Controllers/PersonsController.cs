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

        private ITaskRepository repository;

        public PersonsController() : this(new TaskRepository()) { }

        public PersonsController(ITaskRepository repository)
        {
            this.repository = repository;
        }      
        //
        // GET: /Persons/

        public ActionResult Index()
        {
            return View(repository.PersonsList());
        }

        public ActionResult TasksList(int PersonId)
        {
            var tasks = repository.TasksByPerson(PersonId);

            return View(tasks);
        }
    }
}
