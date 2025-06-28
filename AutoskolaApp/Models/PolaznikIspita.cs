using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class PolaznikIspita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDPolaznika { get; set; }

        public int IDStudenta { get; set; } // Foreign key
        public Student Student { get; set; } // Navigation property
        public int IDIspita { get; set; } // Foreign key
        public Ispit Ispit { get; set; } // Navigation property
        public string Rezultat { get; set; } // Prošao, pao

        public PolaznikIspita()
        {
        }

        public PolaznikIspita(int iDPolaznika, int iDStudenta, Student student, int iDIspita, Ispit ispit, string rezultat)
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
