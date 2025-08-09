using AutoskolaApp.Services;
using AutoskolaApp.ViewModels;
using AutoskolaApp.ViewModels.FormViewModels;
using AutoskolaApp.ViewModels.ListingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoskolaApp.Commands.EditCommands
{
    public class EditInstruktorCommand : AsyncCommandBase
    {
        private readonly InstruktoriFormViewModel _formViewModel;
        private readonly InstruktorService _instruktorService;
        private readonly NavigationService<InstruktoriListingViewModel> _instruktoriListingViewModelNavigationService;

        public EditInstruktorCommand(InstruktoriFormViewModel formViewModel, InstruktorService instruktorService, NavigationService<InstruktoriListingViewModel> instruktoriListingViewModelNavigationService)
        {
            _formViewModel = formViewModel;
            _instruktorService = instruktorService;
            _instruktoriListingViewModelNavigationService = instruktoriListingViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return _formViewModel.IsEditMode;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                _instruktorService.EditInstruktor(_formViewModel.Instruktor);

                _instruktoriListingViewModelNavigationService.Navigate(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
