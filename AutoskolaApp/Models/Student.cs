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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDStudenta { get; set; }

        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumPocetka { get; set; }
        public int SatiVoznje { get; set; }
        public int IDKorisnika { get; set; } // Foreign key
        public Korisnik Korisnik { get; set; } // Navigation property
        public ICollection<PolaznikIspita>? PolazniciIspita { get; set; }
        public ICollection<Uplata>? Uplate { get; set; }
        public ICollection<Voznja>? Voznje { get; set; }

        public Student()
        {
        }
        
        public Student(int iDStudenta, string oIB, string ime, string prezime, DateTime datumRodjenja, DateTime datumPocetka, int satiVoznje, int iDKorisnika, Korisnik korisnik, ICollection<PolaznikIspita>? polazniciIspita, ICollection<Uplata>? uplate, ICollection<Voznja>? voznje)
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

        public Student(int iDStudenta, string oIB, string ime, string prezime, DateTime datumRodjenja, DateTime datumPocetka, int satiVoznje, int iDKorisnika)
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

        public Student(string oIB, string ime, string prezime, DateTime datumRodjenja, DateTime datumPocetka, int satiVoznje, int iDKorisnika)
        {
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
