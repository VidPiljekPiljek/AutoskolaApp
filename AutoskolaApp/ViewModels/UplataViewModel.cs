using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;

namespace AutoskolaApp.ViewModels
{
    public class UplataViewModel
    {
        private readonly Uplata _uplata;

        public int IDUplate => _uplata.IDUplate;

        public DateTime DatumUplate => _uplata.DatumUplate;
        public decimal Iznos => _uplata.Iznos;
        public string NacinUplate => _uplata.NacinUplate;
        public int IDStudenta => _uplata.IDStudenta;

        public UplataViewModel(Uplata uplata)
        {
            _uplata = uplata;
        }

        public UplataViewModel()
        {
        }
    }
}
