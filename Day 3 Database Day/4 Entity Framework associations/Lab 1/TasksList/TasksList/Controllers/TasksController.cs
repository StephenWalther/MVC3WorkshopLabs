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

        TasksListDB db = new TasksListDB();

        public ActionResult Index()
        {           
            return View(db.Tasks);
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
                db.Tasks.Add(newTask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newTask);
        }

        public ActionResult Edit(int Id)
        {
            return View(db.Tasks.Find(Id));
        }

        [HttpPost]
        public ActionResult Edit(Task taskToEdit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskToEdit).State = System.Data.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
