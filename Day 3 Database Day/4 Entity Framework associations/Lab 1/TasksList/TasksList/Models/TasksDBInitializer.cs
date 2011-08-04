using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TasksList.Models
{
    public class TasksDBInitializer : DropCreateDatabaseIfModelChanges<TasksListDB>   
    {
        protected override void Seed(TasksListDB context)
        {          

            var t1 = new Task { Id = 1, Name = "Urgent Task", DateCreated = DateTime.Parse("1/1/2011"), Difficulty = 2, IsDone = true };
            var t2 = new Task { Id = 2, Name = "Business Task", DateCreated = DateTime.Parse("2/4/2011"), Difficulty = 1, IsDone = true };
            var t3 = new Task { Id = 3, Name = "Home Task", DateCreated = DateTime.Now, Difficulty = 2, IsDone = false };
            var t4 = new Task { Id = 4, Name = "Bank Deposit", DateCreated = DateTime.Parse("2/5/2010"), Difficulty = 3, IsDone = false };
            var t5 = new Task { Id = 5, Name = "Tuition Work", DateCreated = DateTime.Parse("5/5/2010"), Difficulty = 4, IsDone = false };
            var t6 = new Task { Id = 6, Name = "Development Task", DateCreated = DateTime.Parse("2/3/2008"), Difficulty = 5, IsDone = false };
                       
            context.Tasks.Add(t1);
            context.Tasks.Add(t2);
            context.Tasks.Add(t3);
            context.Tasks.Add(t4);
            context.Tasks.Add(t5);         

            var Persons = new List<Person> { 
         new Person { Id= 1 , Age= 40, EmailAddress= "Stephen@superexpert.com", FirstName= "Stephen", LastName="Walther", Tasks= new List<Task> { t1,t2 }},
         new Person { Id= 2 , Age= 30, EmailAddress= "John@hotmail.com", FirstName= "John", LastName="Smith" , Tasks= new List<Task> { t3}  },
         new Person { Id= 3 , Age= 29, EmailAddress= "David@hotmail.com", FirstName= "Brain", LastName="Salmon" , Tasks= new List<Task> { t4 } },
         new Person { Id= 4 , Age= 35, EmailAddress= "Barel@hotmail.com", FirstName= "David", LastName="Barel" , Tasks= new List<Task> { t5 } }};

            Persons.ForEach(p => context.Persons.Add(p));
           context.SaveChanges();
        }
    }
}