using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels;

namespace AutoskolaApp.Commands
{
    public class CreateAccountCommand : AsyncCommandBase
    {
        private readonly SignUpViewModel _signUpViewModel;
        private readonly KorisnikService _korisnikService;
        private readonly NavigationService<DashboardViewModel> _dashboardViewModelNavigationService;

        public CreateAccountCommand(SignUpViewModel signUpViewModel, KorisnikService korisnikService, NavigationService<DashboardViewModel> dashboardViewModelNavigationService)
        {
            _signUpViewModel = signUpViewModel;
            _korisnikService = korisnikService;
            _dashboardViewModelNavigationService = dashboardViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return base.CanExecute(parameter);
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            Korisnik korisnik = new Korisnik(
                    new Guid(),
                    _signUpViewModel.KorisnickoIme,
                    _signUpViewModel.Lozinka,
                    _signUpViewModel.Uloga
                );
        }
    }
}
