using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Student
    {
        public string OIB { get; }
        public string Ime { get; }
        public string Prezime { get; }
        public DateTime DatumRodjenja { get; }
        public DateTime DatumPocetka { get; }
        public int SatiVoznje { get; }

        public Student(string oib, string ime, string prezime, DateTime datumRodjenja, DateTime datumPocetka, int satiVoznje)
        {
            OIB = oib;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            DatumPocetka = datumPocetka;
            SatiVoznje = satiVoznje;
        }
    }
}
