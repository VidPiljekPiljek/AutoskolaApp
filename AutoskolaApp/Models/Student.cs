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
        [Key, ForeignKey("Korisnik")]
        public Guid IDStudenta { get; set; }

        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumPocetka { get; set; }
        public int SatiVoznje { get; set; }
        public Korisnik Korisnik { get; set; }
        public ICollection<PolaznikIspita>? PolazniciIspita { get; set; }
        public ICollection<Uplata>? Uplate { get; set; }

        public Student(Guid iDStudenta, string oib, string ime, string prezime, DateTime datumRodjenja, DateTime datumPocetka, int satiVoznje, Korisnik korisnik, ICollection<PolaznikIspita>? polazniciIspita, ICollection<Uplata>? uplate)
        {
            IDStudenta = iDStudenta;
            OIB = oib;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            DatumPocetka = datumPocetka;
            SatiVoznje = satiVoznje;
            Korisnik = korisnik;
            PolazniciIspita = polazniciIspita;
            Uplate = uplate;
        }

        public Student()
        {
        }
    }
}
