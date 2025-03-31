using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;
using AutoskolaApp.Commands;
using AutoskolaApp.Models;
using AutoskolaApp.Repositories;
using AutoskolaApp.Services;
using AutoskolaApp.Stores;

namespace AutoskolaApp.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        private readonly UlogaStore _ulogaStore;
        private ObservableCollection<Uloga> _uloge;

        public ObservableCollection<Uloga> Uloge
        {
            get { return _uloge; }
            set
            {
                _uloge = value;
                OnPropertyChanged(nameof(Uloge));
            }
        }

        private void LoadUloge()
        {
            var uloge = _ulogaStore.Uloge;

            Uloge = new ObservableCollection<Uloga>(uloge);
        }

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
        public Uloga _uloga;
        public Uloga Uloga
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

        public SignUpViewModel(KorisnikService korisnikService, NavigationService<DashboardViewModel> dashboardNavigationService, NavigationService<LoginViewModel> loginNavigationService)
        {
            SubmitCommand = new CreateAccountCommand(this, korisnikService, dashboardNavigationService);
            BackToLoginCommand = new NavigateCommand<LoginViewModel>(loginNavigationService);
        }
    }
}
