using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TasksList.Models
{
    public class TasksListDB : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Task> Tasks { get; set; }   
    }
}