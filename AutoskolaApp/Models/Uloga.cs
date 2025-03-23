using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Uloga
    {
        [Key]
        public Guid IDUloge { get; set; }

        public string ImeUloge { get; set; }
        public ICollection<Korisnik>? Korisnici { get; set; }


        public Uloga(Guid iDUloge, string imeUloge, ICollection<Korisnik>? korisnici)
        {
            IDUloge = iDUloge;
            ImeUloge = imeUloge;
            Korisnici = korisnici;
        }

        public Uloga()
        {
        }
    }
}
