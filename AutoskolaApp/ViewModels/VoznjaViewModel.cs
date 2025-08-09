using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;

namespace AutoskolaApp.ViewModels
{
    public class VoznjaViewModel
    {
        private readonly Voznja _voznja;

        public int IDVoznje => _voznja.IDVoznje;
        public DateTime DatumVoznje => _voznja.DatumVoznje;
        public int IDStudenta => _voznja.IDStudenta;
        public int IDInstruktora => _voznja.IDInstruktora;

        public VoznjaViewModel(Voznja voznja) => _voznja = voznja;

        public VoznjaViewModel()
        {
        }
    }
}
