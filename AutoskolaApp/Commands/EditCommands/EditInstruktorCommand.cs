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
        private readonly InstruktoriListingViewModel _listingViewModel;
        private readonly NavigationService<InstruktoriFormViewModel> _instruktoriFormViewNavigationService;

        public EditInstruktorCommand(InstruktoriListingViewModel dashboardViewModel, NavigationService<InstruktoriFormViewModel> instruktoriListingViewNavigationService)
        {
            _listingViewModel = dashboardViewModel;
            _instruktoriFormViewNavigationService = instruktoriListingViewNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                _instruktoriFormViewNavigationService.Navigate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
