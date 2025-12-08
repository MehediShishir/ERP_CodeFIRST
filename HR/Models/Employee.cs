using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [DisplayName("Name")]
        public string EmployeeName { get; set; }
        [DisplayName("Email")]
        public string EmployeeEmail { get; set; }
        [DisplayName("Mobile No")]
        public string EmployeeMobileNo { get; set; }
        [DisplayName("Address")]
        public string EmployeeAddress { get; set; }


    }
}