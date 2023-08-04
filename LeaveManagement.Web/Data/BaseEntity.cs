namespace LeaveManagement.Web.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; } // Primary Key autoincrementante
        public DateTime DateCreate { get; set; } // Data della creazione
        public DateTime DateModified { get; set; } // Data ultima modifica
    }
}
