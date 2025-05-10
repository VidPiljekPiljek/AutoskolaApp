using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.ViewModels.FormViewModels
{
    public class KorisnikFormViewModel : ViewModelBase
    {
        private string _korisnickoIme;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set
            {
                _korisnickoIme = value;
                OnPropertyChanged(nameof(KorisnickoIme));
            }
        }

        private string _lozinka;
        public string Lozinka
        {
            get { return _lozinka; }
            set
            {
                _lozinka = value;
                OnPropertyChanged(nameof(Lozinka));
            }
        }

        private string _uloga;
        public string Uloga
        {
            get { return _uloga; }
            set
            {
                _uloga = value;
                OnPropertyChanged(nameof(Uloga));
            }
        }

        public 
    }
}
