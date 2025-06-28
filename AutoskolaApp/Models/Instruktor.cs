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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDInstruktora { get; set; }

        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string? Napomena { get; set; }
        public int IDKorisnika { get; set; } // Foreign key
        public Korisnik Korisnik { get; set; } // Navigation property
        public Vozilo? Vozilo { get; set; } // Navigation property to dependent entity
        public ICollection<Ispit>? Ispiti { get; set; }
        public ICollection<Voznja>? Voznje { get; set; }

        public Instruktor()
        {
        }

        public Instruktor(int iDInstruktora, string oIB, string ime, string prezime, DateTime datumZaposlenja, string? napomena, int iDKorisnika, Korisnik korisnik, Vozilo? vozilo, ICollection<Ispit>? ispiti, ICollection<Voznja>? voznje)
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

        public Instruktor(int iDInstruktora, string oIB, string ime, string prezime, DateTime datumZaposlenja, string? napomena, int iDKorisnika)
        {
            IDInstruktora = iDInstruktora;
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
            DatumZaposlenja = datumZaposlenja;
            Napomena = napomena;
            IDKorisnika = iDKorisnika;
        }

        public Instruktor(string oIB, string ime, string prezime, DateTime datumZaposlenja, string? napomena, int iDKorisnika)
        {
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
            DatumZaposlenja = datumZaposlenja;
            Napomena = napomena;
            IDKorisnika = iDKorisnika;
        }
    }
}
