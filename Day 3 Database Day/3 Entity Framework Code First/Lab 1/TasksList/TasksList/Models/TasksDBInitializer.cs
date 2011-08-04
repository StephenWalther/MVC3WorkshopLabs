using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TasksList.Models
{
    public class TasksDBInitializer : DropCreateDatabaseIfModelChanges<TasksDB>
    {
        protected override void Seed(TasksDB context)
        {
            var tasks = new List<Task>()
            {
                new Task { Id=1, Name = "Task 1", Difficulty = 1, DateCreated = DateTime.Parse("1/12/2011") , IsDone= true },
                new Task { Id=1, Name = "Task 2", Difficulty = 2, DateCreated = DateTime.Parse("11/2/2011") , IsDone = false},  
                new Task { Id=1, Name = "Task 3", Difficulty = 3, DateCreated = DateTime.Parse("11/2/2011") , IsDone = false},
                new Task { Id=1, Name = "Task 4", Difficulty = 5, DateCreated = DateTime.Parse("1/2/2010") , IsDone= true }
            };
            tasks.ForEach(t => context.Tasks.Add(t));            
        }
    }
}