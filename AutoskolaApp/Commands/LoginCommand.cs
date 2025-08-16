using AutoskolaApp.Services;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

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
            return !string.IsNullOrEmpty(_loginViewModel.KorisnickoIme) || !string.IsNullOrEmpty(_loginViewModel.Lozinka);
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                if (await _korisnikService.KorisnikAuthentication(_loginViewModel.KorisnickoIme, _loginViewModel.Lozinka))
                {
                    // Check User Role and set NavigationItems to be the one that the user has access to
                    //var userRole = _korisnikService.GetRole(_loginViewModel.KorisnickoIme);
                    //_dashboardViewModelNavigationService.NavigationItems = NavigationItems.GetNavigationItems(userRole);

                    var korisnikType = _korisnikService.KorisnikAuthorization();

                    _dashboardViewModelNavigationService.Navigate(null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
