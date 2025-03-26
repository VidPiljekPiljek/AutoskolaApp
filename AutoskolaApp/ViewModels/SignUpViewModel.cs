using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AutoskolaApp.Commands;

namespace AutoskolaApp.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        public string _korisnickoIme;
        public string KorisnickoIme
        {
            get 
            { 
                return _korisnickoIme; 
            }
            set 
            { 
                _korisnickoIme = value;

                OnPropertyChanged(nameof(KorisnickoIme));
            }
        }
        public string _lozinka;
        public string Lozinka
        {
            get { return _lozinka; }
            set 
            { 
                _lozinka = value; 
                OnPropertyChanged(nameof(Lozinka)); 
            }
        }
        public string _uloga;
        public string Uloga
        {
            get { return _uloga; }
            set 
            { 
                _uloga = value; 
                OnPropertyChanged(nameof(Uloga)); 
            }
        }

        public AsyncCommandBase SubmitCommand { get; }
        public ICommand BackToLoginCommand { get; }

        public SignUpViewModel()
        {
        }
    }
}
