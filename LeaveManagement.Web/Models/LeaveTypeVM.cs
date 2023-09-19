using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Tipo congedo")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Numero di giorni base")]
        [Required]
        [Range(1, 180, ErrorMessage = "Perfavore Inserire Un Numero Valido")]
        public int DefaultDays { get; set; }
    }
}
