﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DFEmployees.Models
{
    public class EmployeesDB : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}