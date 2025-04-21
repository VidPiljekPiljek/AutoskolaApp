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
        [Key]
        public Guid IDInstruktora { get; set; }

        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string? Napomena { get; set; }
        public Guid IDKorisnika { get; set; } // Foreign key
        public Korisnik Korisnik { get; set; } // Navigation property
        public Vozilo? Vozilo { get; set; } // Navigation property to dependent entity
        public ICollection<Ispit>? Ispiti { get; set; }
        public ICollection<Voznja>? Voznje { get; set; }

        public Instruktor()
        {
        }

        public Instruktor(Guid iDInstruktora, string oIB, string ime, string prezime, DateTime datumZaposlenja, string? napomena, Guid iDKorisnika, Korisnik korisnik, Vozilo? vozilo, ICollection<Ispit>? ispiti, ICollection<Voznja>? voznje)
        {
            IDInstruktora = iDInstruktora;
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
            DatumZaposlenja = datumZaposlenja;
            Napomena = napomena;
            IDKorisnika = iDKorisnika;
            Korisnik = korisnik;
            Vozilo = vozilo;
            Ispiti = ispiti;
            Voznje = voznje;
        }

        public Instruktor(Guid iDInstruktora, string oIB, string ime, string prezime, DateTime datumZaposlenja, string? napomena, Guid iDKorisnika)
        {
            IDInstruktora = iDInstruktora;
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
            DatumZaposlenja = datumZaposlenja;
            Napomena = napomena;
            IDKorisnika = iDKorisnika;
        }
    }
}
