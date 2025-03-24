using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Voznja
    {
        [Key]
        public Guid IDVoznje { get; set; }

        public DateTime DatumVoznje { get; set; }
        public Guid IDStudenta { get; set; } // Foreign key
        public Student Student { get; set; } // Navigation property
        public Guid IDInstruktora { get; set; } // Foreign key
        public Instruktor Instruktor { get; set; } // Navigation property

        public Voznja()
        {
        }

        public Voznja(Guid iDVoznje, DateTime datumVoznje, Guid iDStudenta, Student student, Guid iDInstruktora, Instruktor instruktor)
        {
            IDVoznje = iDVoznje;
            DatumVoznje = datumVoznje;
            IDStudenta = iDStudenta;
            Student = student;
            IDInstruktora = iDInstruktora;
            Instruktor = instruktor;
        }
    }
}
