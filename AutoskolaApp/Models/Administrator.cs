using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Administrator
    {
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Administrator(string oib, string ime, string prezime)
        {
            OIB = oib;
            Ime = ime;
            Prezime = prezime;
        }
    }
}
