using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TasksList.Models
{
    public class Person
    {
        public int Id { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }        
        public string EmailAddress { get; set; }        
        public virtual ICollection<Task> Tasks { get; set; }
    }
}