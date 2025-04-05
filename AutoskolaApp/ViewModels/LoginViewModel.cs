using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;
using AutoskolaApp.Commands;
using AutoskolaApp.Services;

namespace AutoskolaApp.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly KorisnikService _korisnikService;
        public ICommand GoToAccountCreationCommand { get; }
        public ICommand LoginCommand { get; }
        public ICommand LoadKorisniciCommand { get; } // On the start of the app

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

        public LoginViewModel(KorisnikService korisnikService, NavigationService<SignUpViewModel> signUpNavigationService)
        {
            _korisnikService = korisnikService;
            GoToAccountCreationCommand = new NavigateCommand<SignUpViewModel>(signUpNavigationService);
        }

        public static LoginViewModel LoadViewModel(KorisnikService korisnikService, NavigationService<SignUpViewModel> signUpNavigationService)
        {
            LoginViewModel loginViewModel = new LoginViewModel(korisnikService, signUpNavigationService);

            loginViewModel.LoadKorisniciCommand.Execute(null);

            return loginViewModel;
        }
    }
}
