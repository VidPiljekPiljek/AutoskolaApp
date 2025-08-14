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
    class EditVoznjaCommand : AsyncCommandBase
    {
        private readonly VoznjeFormViewModel _formViewModel;
        private readonly VoznjaService _voznjaService;
        private readonly NavigationService<VoznjeListingViewModel> _voznjeListingViewModelNavigationService;

        public EditVoznjaCommand(VoznjeFormViewModel formViewModel, VoznjaService voznjaService, NavigationService<VoznjeListingViewModel> voznjeListingViewModelNavigationService)
        {
            _formViewModel = formViewModel;
            _voznjaService = voznjaService;
            _voznjeListingViewModelNavigationService = voznjeListingViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return _formViewModel.IsEditMode;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                _voznjaService.EditVoznja(_formViewModel.Voznja);

                _voznjeListingViewModelNavigationService.Navigate(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
