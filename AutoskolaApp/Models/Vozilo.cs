using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Vozilo
    {
        public string Registracija { get; }
        public string Marka { get; }
        public string Model { get; }
        public Instruktor Instruktor { get; }

        public Vozilo(string registracija, string marka, string model, Instruktor instruktor)
        {
            Registracija = registracija;
            Marka = marka;
            Model = model;
            Instruktor = instruktor;
        }
    }
}
