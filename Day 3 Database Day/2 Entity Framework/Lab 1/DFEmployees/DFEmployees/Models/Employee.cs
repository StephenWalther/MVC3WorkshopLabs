using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFEmployees.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int YearsAtCompany { get; set; }
    }
}