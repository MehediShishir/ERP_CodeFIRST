using HR.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int LeaveTypeID { get; set; }

        [DisplayName("Leave Start Date")]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }



        public virtual LeaveType LeaveType { get; set; }
    }




}