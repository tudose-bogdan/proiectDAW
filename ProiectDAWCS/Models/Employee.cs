using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProiectDAWCS.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int Salary { get; set; }
        public String JobName { get; set; }





    }

    public class HRContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

    }
}

