using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Ispit
    {
        [Key]
        public Guid IDIspita { get; set; }

        public DateTime DateTime { get; set; }
        public string VrstaIspita { get; set; } //Propisi, prva pomoć, vozački
        public Instruktor Instruktor { get; set; }
        public ICollection<PolaznikIspita> PolazniciIspita { get; }

        public Ispit(Guid iDIspita, DateTime dateTime, string vrstaIspita, Instruktor instruktor, ICollection<PolaznikIspita> polazniciIspita)
        {
            IDIspita = iDIspita;
            DateTime = dateTime;
            VrstaIspita = vrstaIspita;
            Instruktor = instruktor;
            PolazniciIspita = polazniciIspita;
        }

        public Ispit()
        {
        }
    }
}
