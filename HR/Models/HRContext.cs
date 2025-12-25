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

        public DbSet<Department> Departments { get; set; }

        public DbSet<Designation> Designations { get; set; }

        public DbSet<Attendance> Attendances { get; set; }

        public DbSet<LeaveApplication> LeaveApplications { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public System.Data.Entity.DbSet<HR.Models.LeaveType> LeaveTypes { get; set; }
    }
}