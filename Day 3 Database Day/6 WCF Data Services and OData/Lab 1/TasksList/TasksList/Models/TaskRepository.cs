using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace TasksList.Models
{
    public class TaskRepository : ITaskRepository
    {
        private TasksListDB db = new TasksListDB();

        public List<Person> PersonsList()
        {
            return db.Persons.ToList();
        }

        public IQueryable<Task> TasksByPerson(int personId)
        {
            return db.Tasks.Where(t => t.Person.Id == personId);
        }

        public IQueryable<Task> TasksList()
        {
            return db.Tasks;
        }

        public Task CreateTask(Task taskToCreate)
        {
            db.Tasks.Add(taskToCreate);
            db.SaveChanges();
            return taskToCreate;
        }

        public Task GetTask(int Id)
        {
            return db.Tasks.Find(Id);
        }

        public Task EditTask(Task taskToEdit)
        {
            db.Entry(taskToEdit).State = EntityState.Modified;
            db.SaveChanges();
            return taskToEdit;
        }
    }
}