using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasksList.Models;

namespace TasksList.Controllers
{
    public class TasksController : Controller
    {
        //
        // GET: /Tasks/

        private ITaskRepository repository;

        public TasksController() : this(new TaskRepository()) { }

        public TasksController(ITaskRepository repository)
        {
            this.repository = repository;
        }
    
        public ActionResult Index()
        {
            return View(repository.TasksList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Task newTask)
        {

            if (ModelState.IsValid)
            {
                repository.CreateTask(newTask);
                return RedirectToAction("Index");
            }
            return View(newTask);
        }

        public ActionResult Edit(int Id)
        {
            return View(repository.GetTask(Id));
        }

        [HttpPost]
        public ActionResult Edit(Task taskToEdit)
        {
            if (ModelState.IsValid)
            {
                repository.EditTask(taskToEdit);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
