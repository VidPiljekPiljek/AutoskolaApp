using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Administrator
    {
        [Key]
        public Guid IDAdministratora { get; set; }

        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Guid IDKorisnika { get; set; } // Foreign key
        public Korisnik Korisnik { get; set; } // Navigation property

        public Administrator()
        {
        }

        public Administrator(Guid iDAdministratora, string oIB, string ime, string prezime, Guid iDKorisnika, Korisnik korisnik)
        {
            IDAdministratora = iDAdministratora;
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
            IDKorisnika = iDKorisnika;
            Korisnik = korisnik;
        }

        public Administrator(Guid iDAdministratora, string oIB, string ime, string prezime, Guid iDKorisnika)
        {
            IDAdministratora = iDAdministratora;
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
            IDKorisnika = iDKorisnika;
        }
    }
}
