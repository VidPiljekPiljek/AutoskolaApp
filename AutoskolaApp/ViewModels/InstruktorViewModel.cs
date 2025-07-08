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

        public int IDInstruktora => _instruktor.IDInstruktora;

        public string OIB => _instruktor.OIB;
        public string Ime => _instruktor.Ime;
        public string Prezime => _instruktor.Prezime;
        public DateTime DatumZaposlenja => _instruktor.DatumZaposlenja;
        public string? Napomena => _instruktor.Napomena;
        public int IDKorisnika => _instruktor.IDKorisnika;

        public InstruktorViewModel(Instruktor instruktor)
        {
            _instruktor = instruktor;
        }
    }
}
