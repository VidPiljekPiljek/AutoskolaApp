using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Models
{
    public class Ispit
    {
        public Guid IDIspita { get; }
        public DateTime DateTime { get; }
        public string VrstaIspita { get; } //Propisi, prva pomoć, vožnja

        public Ispit(Guid iDIspita, DateTime dateTime, string vrstaIspita)
        {
            IDIspita = iDIspita;
            DateTime = dateTime;
            VrstaIspita = vrstaIspita;
        }
    }
}
