using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.FormViewModels;
using AutoskolaApp.ViewModels.ListingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoskolaApp.Commands.DeletionCommands
{
    public class DeleteInstruktorCommand : AsyncCommandBase
    {
        private readonly InstruktoriListingViewModel _formViewModel;
        private readonly KorisnikService _korisnikService;
        private readonly InstruktorService _instruktorService;
        private readonly NavigationService<InstruktoriListingViewModel> _instruktoriListingViewModelNavigationService;

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                Instruktor instruktor = new Instruktor(
                    _formViewModel.SelectedInstruktor.OIB,
                    _formViewModel.SelectedInstruktor.Ime,
                    _formViewModel.SelectedInstruktor.Prezime,
                    _formViewModel.SelectedInstruktor.DatumZaposlenja,
                    _formViewModel.SelectedInstruktor.Napomena,
                    _formViewModel.SelectedInstruktor.IDInstruktora
                );

                //await _korisnikService.AddKorisnik(korisnik);

                await _instruktorService.DeleteInstruktor(instruktor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
