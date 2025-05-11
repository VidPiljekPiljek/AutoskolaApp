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

        public Guid IDVoznje { get; set; }
        public DateTime DatumVoznje => _voznja.DatumVoznje;
        public Guid IDStudenta => _voznja.IDStudenta;


        public VoznjaViewModel(Voznja voznja) => _voznja = voznja;
    }
}
