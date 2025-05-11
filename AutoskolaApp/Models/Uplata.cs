using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Uplata
    {
        [Key]
        public Guid IDUplate { get; set; }

        public DateTime DatumUplate { get; set; }
        public decimal Iznos { get; set; }
        public string NacinUplate { get; set; }
        public Guid IDStudenta { get; set; } // Foreign key
        public Student Student { get; set; } // Navigation property

        public Uplata()
        {
        }

        public Uplata(Guid iDUplate, DateTime datumUplate, decimal iznos, string nacinUplate, Guid iDStudenta, Student student)
        {
            IDUplate = iDUplate;
            DatumUplate = datumUplate;
            Iznos = iznos;
            NacinUplate = nacinUplate;
            IDStudenta = iDStudenta;
            Student = student;
        }
        public Uplata(DateTime datumUplate, decimal iznos, string nacinUplate, Guid iDStudenta)
        {
            DatumUplate = datumUplate;
            Iznos = iznos;
            NacinUplate = nacinUplate;
            IDStudenta = iDStudenta;
        }
    }
}
