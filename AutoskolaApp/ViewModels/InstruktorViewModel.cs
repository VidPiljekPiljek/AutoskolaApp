using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;

namespace AutoskolaApp.ViewModels
{
    public class InstruktorViewModel : ViewModelBase
    {
        private readonly Instruktor _instruktor;

        public Guid IDInstruktora { get; set; }

        public string OIB => _instruktor.OIB;
        public string Ime => _instruktor.Ime;
        public string Prezime => _instruktor.Prezime;
        public string DatumZaposlenja => _instruktor.DatumZaposlenja.ToString("d");
        public string? Napomena => _instruktor.Napomena;

        public InstruktorViewModel(Instruktor instruktor)
        {
            _instruktor = instruktor;
        }
    }
}
