using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Voznja
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDVoznje { get; set; }

        public DateTime DatumVoznje { get; set; }
        public int IDStudenta { get; set; } // Foreign key
        public Student Student { get; set; } // Navigation property
        public int IDInstruktora { get; set; } // Foreign key
        public Instruktor Instruktor { get; set; } // Navigation property

        public Voznja()
        {
        }

        public Voznja(int iDVoznje, DateTime datumVoznje, int iDStudenta, Student student, int iDInstruktora, Instruktor instruktor)
        {
            IDVoznje = iDVoznje;
            DatumVoznje = datumVoznje;
            IDStudenta = iDStudenta;
            Student = student;
            IDInstruktora = iDInstruktora;
            Instruktor = instruktor;
        }

        public Voznja(DateTime datumVoznje, int iDStudenta, int iDInstruktora)
        {
            DatumVoznje = datumVoznje;
            IDStudenta = iDStudenta;
            IDInstruktora = iDInstruktora;
        }
    }
}
