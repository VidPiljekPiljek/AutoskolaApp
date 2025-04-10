using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using AutoskolaApp.Services;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels;

namespace AutoskolaApp.Commands
{
    public class LoginCommand : AsyncCommandBase
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly KorisnikService _korisnikService;
        private readonly NavigationService<DashboardViewModel> _dashboardViewModelNavigationService;

        public LoginCommand(LoginViewModel loginViewModel, KorisnikService korisnikService, NavigationService<DashboardViewModel> dashboardViewModelNavigationService)
        {
            _loginViewModel = loginViewModel;
            _korisnikService = korisnikService;
            _dashboardViewModelNavigationService = dashboardViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override Task ExecuteAsync(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
