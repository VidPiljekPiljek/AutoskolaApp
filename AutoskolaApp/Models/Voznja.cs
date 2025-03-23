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
        public Student Student { get; set; }
        public Instruktor Instruktor { get; set; } // Pitanje jel nam treba Instruktor, mozda samo User? Mozda User moze biti interface?

        public Voznja(Guid iDVoznje, DateTime datumVoznje, Student student, Instruktor instruktor)
        {
            IDVoznje = iDVoznje;
            DatumVoznje = datumVoznje;
            Student = student;
            Instruktor = instruktor;
        }

        public Voznja()
        {
        }
    }
}
