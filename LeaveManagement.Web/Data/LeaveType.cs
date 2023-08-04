namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; } // Name che verrà stabilito dall'admin del sistema scegliendo tra quelli disponibili di default
        public int DefaultDays { get; set; } // Numero di giorni preimpostati

    }
}
