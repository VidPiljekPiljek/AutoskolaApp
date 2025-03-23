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

        public Student Student { get; set; }
        public Ispit Ispit { get; set; }
        public string Rezultat { get; set; } // Prošao, pao

        public PolaznikIspita(Guid idPolaznika, Student student, Ispit ispit, string rezultat)
        {
            IDPolaznika = idPolaznika;
            Student = student;
            Ispit = ispit;
            Rezultat = rezultat;
        }

        public PolaznikIspita()
        {
        }
    }
}
