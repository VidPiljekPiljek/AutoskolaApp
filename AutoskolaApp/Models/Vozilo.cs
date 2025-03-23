using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Vozilo
    {
        [Key]
        public string Registracija { get; set; }

        public string Marka { get; set; }
        public string Model { get; set; }
        public Instruktor Instruktor { get; set; }

        public Vozilo(string registracija, string marka, string model, Instruktor instruktor)
        {
            Registracija = registracija;
            Marka = marka;
            Model = model;
            Instruktor = instruktor;
        }

        public Vozilo()
        {
        }
    }
}
