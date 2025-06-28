using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Ispit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDIspita { get; set; }

        public DateTime DateTime { get; set; }
        public string VrstaIspita { get; set; } //Propisi, prva pomoć, vozački
        public int IDInstruktora { get; set; } // Foreign Key
        public Instruktor Instruktor { get; set; } // Navigation Property
        public ICollection<PolaznikIspita> PolazniciIspita { get; }

        public Ispit()
        {
        }

        public Ispit(int iDIspita, DateTime dateTime, string vrstaIspita, int iDInstruktora, Instruktor instruktor, ICollection<PolaznikIspita> polazniciIspita)
        {
            IDIspita = iDIspita;
            DateTime = dateTime;
            VrstaIspita = vrstaIspita;
            IDInstruktora = iDInstruktora;
            Instruktor = instruktor;
            PolazniciIspita = polazniciIspita;
        }
    }
}
