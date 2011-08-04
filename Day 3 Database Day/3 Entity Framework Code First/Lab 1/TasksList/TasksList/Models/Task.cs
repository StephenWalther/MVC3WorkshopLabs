using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TasksList.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        [Range(1,5,ErrorMessage="Difficulty must be between 1 and 5")]
        public int Difficulty { get; set; }
        
        public bool IsDone { get; set; }
    }
}