using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class HRContext:DbContext
    {
        public HRContext():base("dberpconnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<HR.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<HR.Models.Designation> Designations { get; set; }

        public System.Data.Entity.DbSet<HR.Models.Attendance> Attendances { get; set; }
    }
}