using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Voznja
    {
        public Guid IDVoznje { get; }
        public DateTime DatumVoznje { get; }
        public Student Student { get; }
        public Instruktor Instruktor { get; } // Pitanje jel nam treba Instruktor, mozda samo User? Mozda User moze biti interface?

        public Voznja(Guid iDVoznje, DateTime datumVoznje, Student student, Instruktor instruktor)
        {
            IDVoznje = iDVoznje;
            DatumVoznje = datumVoznje;
            Student = student;
            Instruktor = instruktor;
        }
    }
}
