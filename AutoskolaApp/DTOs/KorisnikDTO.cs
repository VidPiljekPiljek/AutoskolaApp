using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.DTOs
{
    public class KorisnikDTO
    {
        public Guid IDKorisnika { get; set; } // Primary key
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public Guid IDUloge { get; set; } // Foreign key
    }
}
