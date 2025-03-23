using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Instruktor
    {
        [Key, ForeignKey("Korisnik")]
        public Guid IDInstruktor { get; set; }

        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string? Napomena { get; set; }
        public Korisnik Korisnik { get; set; }
        public ICollection<Ispit>? Ispiti { get; set; }

        public Instruktor(Guid iDInstruktor, string oib, string ime, string prezime, DateTime datumZaposlenja, string? napomena, Korisnik korisnik, ICollection<Ispit>? ispiti)
        {
            IDInstruktor = iDInstruktor;
            OIB = oib;
            Ime = ime;
            Prezime = prezime;
            DatumZaposlenja = datumZaposlenja;
            Napomena = napomena;
            Korisnik = korisnik;
            Ispiti = ispiti;
        }

        public Instruktor()
        {
        }
    }
}
