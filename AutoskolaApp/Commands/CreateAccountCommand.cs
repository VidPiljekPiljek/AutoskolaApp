using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels;

namespace AutoskolaApp.Commands
{
    public class CreateAccountCommand : AsyncCommandBase
    {
        private readonly KorisnikService _korisnikService;
        private readonly NavigationService<DashboardViewModel> _dashboardViewModelNavigationService;

        public CreateAccountCommand(KorisnikService korisnikService, NavigationService<DashboardViewModel> dashboardViewModelNavigationService)
        {
            _korisnikService = korisnikService;
            _dashboardViewModelNavigationService = dashboardViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return base.CanExecute(parameter);
        }

        public override Task ExecuteAsync(object? parameter)
        {
            throw new NotImplementedException();
        }

        /* ZA DOVRSITI
        public override async Task ExecuteAsync(object? parameter)
        {
           Korisnik korisnik = new Korisnik(
                   new Guid(),
                   _signUpViewModel.KorisnickoIme,
                   _signUpViewModel.Lozinka,
                   _signUpViewModel.Uloga.IDUloge,
                   _signUpViewModel.Uloga,
                   null,
                   null,
                   null
               );

           try
           {
               await _korisnikService.RegisterKorisnik(korisnik);
               _dashboardViewModelNavigationService.Navigate();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
        }*/
    }
}
