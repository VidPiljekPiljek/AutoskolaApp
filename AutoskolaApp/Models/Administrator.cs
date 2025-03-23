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
        [Key, ForeignKey("Korisnik")]
        public Guid IDAdministratora { get; set; }

        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Korisnik Korisnik { get; set; }

        public Administrator(Guid iDAdministratora, string oib, string ime, string prezime, Korisnik korisnik)
        {
            IDAdministratora = iDAdministratora;
            OIB = oib;
            Ime = ime;
            Prezime = prezime;
            Korisnik = korisnik;
        }

        public Administrator()
        {
        }
    }
}
