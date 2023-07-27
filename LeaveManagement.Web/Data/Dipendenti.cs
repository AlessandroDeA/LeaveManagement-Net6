using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    public class Dipendenti : IdentityUser
    {
        public string? Nome{ get; set; }
        public string? Cognome{ get; set; }
        public string? CodiceFiscale { get; set; }
        public DateTime DataNascita { get; set; }
        public DateTime DataAssunzione { get; set;  }

    }
}
