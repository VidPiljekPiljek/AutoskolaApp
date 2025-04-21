using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;
using AutoskolaApp.Commands;
using AutoskolaApp.Models;
using AutoskolaApp.Services;

namespace AutoskolaApp.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly KorisnikService _korisnikService;
        public ICommand LoginCommand { get; }

        private string _korisnickoIme;
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
        private string _lozinka;
        public string Lozinka
        {
            get
            {
                return _lozinka;
            }
            set
            {
                _lozinka = value;
                OnPropertyChanged(nameof(Lozinka));
            }
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public LoginViewModel(KorisnikService korisnikService, NavigationService<DashboardViewModel> dashboardNavigationService)
        {
            _korisnikService = korisnikService;
            LoginCommand = new LoginCommand(this, _korisnikService, dashboardNavigationService);
        }

        public static LoginViewModel LoadViewModel(KorisnikService korisnikService, NavigationService<DashboardViewModel> dashboardNavigationService)
        {
            LoginViewModel loginViewModel = new LoginViewModel(korisnikService, dashboardNavigationService);

            return loginViewModel;
        }
    }
}
