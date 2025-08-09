using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels;
using AutoskolaApp.ViewModels.FormViewModels;
using AutoskolaApp.ViewModels.ListingViewModels;

namespace AutoskolaApp.Commands.CreationalCommands
{
    public class CreateInstruktorCommand : AsyncCommandBase
    {
        private readonly InstruktoriFormViewModel _formViewModel;
        private readonly KorisnikService _korisnikService;
        private readonly InstruktorService _instruktorService;
        private readonly NavigationService<InstruktoriListingViewModel> _instruktoriListingViewModelNavigationService;

        public CreateInstruktorCommand(InstruktoriFormViewModel formViewModel, KorisnikService korisnikService, InstruktorService instruktorService, NavigationService<InstruktoriListingViewModel> instruktoriListingViewModelNavigationService)
        {
            _formViewModel = formViewModel;
            _korisnikService = korisnikService;
            _instruktorService = instruktorService;
            _instruktoriListingViewModelNavigationService = instruktoriListingViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return !_formViewModel.IsEditMode;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                Korisnik korisnik = new Korisnik(
                    _formViewModel.KorisnickoIme,
                    _formViewModel.Lozinka,
                    2
                );

                await _korisnikService.AddKorisnik(korisnik);

                int korisnikID = await _korisnikService.GetKorisnikID(korisnik.KorisnickoIme, korisnik.Lozinka);

                Instruktor instruktor = new Instruktor(
                    _formViewModel.OIB,
                    _formViewModel.Ime,
                    _formViewModel.Prezime,
                    _formViewModel.DatumPocetka,
                    _formViewModel.Napomena,
                    korisnikID
                    );

                await _instruktorService.AddInstruktor(instruktor);
                _instruktoriListingViewModelNavigationService.Navigate(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
            }
        }
    }
}
