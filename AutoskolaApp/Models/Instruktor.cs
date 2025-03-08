using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Instruktor
    {
        public string OIB { get; }
        public string Ime { get; }
        public string Prezime { get; }
        public DateTime DatumZaposlenja { get; }
        public string Napomena { get; }

        public Instruktor(string oib, string ime, string prezime, DateTime datumZaposlenja, string napomena)
        {
            OIB = oib;
            Ime = ime;
            Prezime = prezime;
            DatumZaposlenja = datumZaposlenja;
            Napomena = napomena;
        }
    }
}
