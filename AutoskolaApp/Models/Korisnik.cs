using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Korisnik
    {
        [Key]
        public Guid IDKorisnika { get; set; }

        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public Uloga Uloga { get; set; }

        public Korisnik(Guid iDKorisnika, string korisnickoIme, string lozinka, Uloga uloga)
        {
            IDKorisnika = iDKorisnika;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Uloga = uloga;
        }

        public Korisnik()
        {
        }
    }
}
