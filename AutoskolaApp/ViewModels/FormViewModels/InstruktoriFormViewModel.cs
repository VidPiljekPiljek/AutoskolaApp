using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.ViewModels.FormViewModels
{
    public class InstruktoriFormViewModel : ViewModelBase
    {
        private string _OIB;
        public string OIB
        {
            get { return _OIB; }
            set
            {
                _OIB = value;
                OnPropertyChanged(nameof(OIB));
            }
        }

        private string _ime;
        public string Ime
        {
            get { return _ime; }
            set
            {
                _ime = value;
                OnPropertyChanged(nameof(Ime));
            }
        }

        private string _prezime;
        public string Prezime
        {
            get { return _prezime; }
            set
            {
                _prezime = value;
                OnPropertyChanged(nameof(Prezime));
            }
        }

        private DateTime _datumRodenja;
        public DateTime DatumRodenja
        {
            get { return _datumRodenja; }
            set
            {
                _datumRodenja = value;
                OnPropertyChanged(nameof(DatumRodenja));
            }
        }

        private DateTime _datumPocetka;
        public DateTime DatumPocetka
        {
            get { return _datumPocetka; }
            set
            {
                _datumPocetka = value;
                OnPropertyChanged(nameof(DatumPocetka));
            }
        }

        public InstruktoriFormViewModel()
        {

        }
    }
}
