using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class PolaznikIspita
    {
        [Key]
        public Guid IDPolaznika { get; set; }

        public Guid IDStudenta { get; set; } // Foreign key
        public Student Student { get; set; } // Navigation property
        public Guid IDIspita { get; set; } // Foreign key
        public Ispit Ispit { get; set; } // Navigation property
        public string Rezultat { get; set; } // Prošao, pao

        public PolaznikIspita()
        {
        }

        public PolaznikIspita(Guid iDPolaznika, Guid iDStudenta, Student student, Guid iDIspita, Ispit ispit, string rezultat)
        {
            IDPolaznika = iDPolaznika;
            IDStudenta = iDStudenta;
            Student = student;
            IDIspita = iDIspita;
            Ispit = ispit;
            Rezultat = rezultat;
        }
    }
}
