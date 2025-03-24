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
        public Guid IDInstruktora { get; set; } // Foreign key
        public Instruktor Instruktor { get; set; } // Navigation property

        public Vozilo()
        {
        }

        public Vozilo(string registracija, string marka, string model, Guid iDInstruktora, Instruktor instruktor)
        {
            Registracija = registracija;
            Marka = marka;
            Model = model;
            IDInstruktora = iDInstruktora;
            Instruktor = instruktor;
        }
    }
}
