using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class LeaveApplication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeaveApplicationID { get; set; }
        [DisplayName("Employee ID")]
        public int EmployeeID { get; set; }
        [DisplayName("Leave Type")]
        public string LeaveType { get; set; }
        [DisplayName("Leave Start Date")]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
    }
}