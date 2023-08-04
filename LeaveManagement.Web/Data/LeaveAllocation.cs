using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; } // A seconda del LeaveTyp, al dipendente verranno assegnati un numero di giorni

        [ForeignKey("LeaveTypeId")]
        public  LeaveType LeaveType { get; set; } 
        public int LeaveTypeId { get; set; }
        public string EmployeeId { get; set; }

    }
}
