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
        public int IDUloge { get; set; } // Foreign key
        public Uloga Uloga { get; set; } // Navigation to principal entity
        public Administrator? Administrator { get; set; } // Navigation to dependent entity
        public Instruktor? Instruktor { get; set; } // Navigation to dependent entity
        public Student? Student { get; set; } // Navigation to dependent entity

        public Korisnik()
        {
        }

        public Korisnik(Guid iDKorisnika, string korisnickoIme, string lozinka, int iDUloge, Uloga uloga, Administrator? administrator, Instruktor? instruktor, Student? student)
        {
            IDKorisnika = iDKorisnika;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            IDUloge = iDUloge;
            Uloga = uloga;
            Administrator = administrator;
            Instruktor = instruktor;
            Student = student;
        }

        public Korisnik(Guid iDKorisnika, string korisnickoIme, string lozinka, int iDUloge)
        {
            IDKorisnika = iDKorisnika;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            IDUloge = iDUloge;
        }

        public Korisnik(string korisnickoIme, string lozinka, int iDUloge)
        {
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            IDUloge = iDUloge;
        }
    }
}
