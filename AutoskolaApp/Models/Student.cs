using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Student
    {
        [Key]
        public Guid IDStudenta { get; set; }

        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumPocetka { get; set; }
        public int SatiVoznje { get; set; }
        public Guid IDKorisnika { get; set; } // Foreign key
        public Korisnik Korisnik { get; set; } // Navigation property
        public ICollection<PolaznikIspita>? PolazniciIspita { get; set; }
        public ICollection<Uplata>? Uplate { get; set; }
        public ICollection<Voznja>? Voznje { get; set; }

        public Student()
        {
        }
        
        public Student(Guid iDStudenta, string oIB, string ime, string prezime, DateTime datumRodjenja, DateTime datumPocetka, int satiVoznje, Guid iDKorisnika, Korisnik korisnik, ICollection<PolaznikIspita>? polazniciIspita, ICollection<Uplata>? uplate, ICollection<Voznja>? voznje)
        {
            IDStudenta = iDStudenta;
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            DatumPocetka = datumPocetka;
            SatiVoznje = satiVoznje;
            IDKorisnika = iDKorisnika;
            Korisnik = korisnik;
            PolazniciIspita = polazniciIspita;
            Uplate = uplate;
            Voznje = voznje;
        }

        public Student(Guid iDStudenta, string oIB, string ime, string prezime, DateTime datumRodjenja, DateTime datumPocetka, int satiVoznje, Guid iDKorisnika)
        {
            IDStudenta = iDStudenta;
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            DatumPocetka = datumPocetka;
            SatiVoznje = satiVoznje;
            IDKorisnika = iDKorisnika;
        }
    }
}
