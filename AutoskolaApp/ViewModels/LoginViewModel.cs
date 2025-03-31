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

        public LoginViewModel(KorisnikService korisnikService, NavigationService<SignUpViewModel> signUpNavigationService, LoginCommand loginCommand)
        {
            _korisnikService = korisnikService;
            GoToAccountCreationCommand = new NavigateCommand<SignUpViewModel>(signUpNavigationService);
            LoginCommand = loginCommand;
        }
    }
}
