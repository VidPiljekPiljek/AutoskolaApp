using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Uplata
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDUplate { get; set; }

        public DateTime DatumUplate { get; set; }
        public decimal Iznos { get; set; }
        public string NacinUplate { get; set; }
        public int IDStudenta { get; set; } // Foreign key
        public Student Student { get; set; } // Navigation property

        public Uplata()
        {
        }

        public Uplata(int iDUplate, DateTime datumUplate, decimal iznos, string nacinUplate, int iDStudenta, Student student)
        {
            IDUplate = iDUplate;
            DatumUplate = datumUplate;
            Iznos = iznos;
            NacinUplate = nacinUplate;
            IDStudenta = iDStudenta;
            Student = student;
        }
        public Uplata(DateTime datumUplate, decimal iznos, string nacinUplate, int iDStudenta)
        {
            DatumUplate = datumUplate;
            Iznos = iznos;
            NacinUplate = nacinUplate;
            IDStudenta = iDStudenta;
        }
    }
}
