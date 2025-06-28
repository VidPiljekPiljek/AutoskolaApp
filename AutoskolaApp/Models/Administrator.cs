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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDAdministratora { get; set; }

        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int IDKorisnika { get; set; } // Foreign key
        public Korisnik Korisnik { get; set; } // Navigation property

        public Administrator()
        {
        }

        public Administrator(int iDAdministratora, string oIB, string ime, string prezime, int iDKorisnika, Korisnik korisnik)
        {
            IDAdministratora = iDAdministratora;
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
            IDKorisnika = iDKorisnika;
            Korisnik = korisnik;
        }

        public Administrator(int iDAdministratora, string oIB, string ime, string prezime, int iDKorisnika)
        {
            IDAdministratora = iDAdministratora;
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
            IDKorisnika = iDKorisnika;
        }
    }
}
