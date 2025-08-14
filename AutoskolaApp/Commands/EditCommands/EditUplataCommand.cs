using AutoskolaApp.Services;
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
    public class EditUplataCommand : AsyncCommandBase
    {
        private readonly UplateFormViewModel _formViewModel;
        private readonly UplataService _uplataService;
        private readonly NavigationService<UplateListingViewModel> _uplateListingViewModelNavigationService;

        public EditUplataCommand(UplateFormViewModel formViewModel, UplataService uplataService, NavigationService<UplateListingViewModel> uplateListingViewModelNavigationService)
        {
            _formViewModel = formViewModel;
            _uplataService = uplataService;
            _uplateListingViewModelNavigationService = uplateListingViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return _formViewModel.IsEditMode;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                _uplataService.EditUplata(_formViewModel.Uplata);

                _uplateListingViewModelNavigationService.Navigate(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
