using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels;
using AutoskolaApp.ViewModels.ListingViewModels;

namespace AutoskolaApp.Commands.DashboardNavigation
{
    public class NavigateToInstruktoriCommand : AsyncCommandBase
    {
        private readonly DashboardViewModel _dashboardViewModel;
        private readonly NavigationService<InstruktoriListingViewModel> _instruktoriListingViewNavigationService;

        public NavigateToInstruktoriCommand(DashboardViewModel dashboardViewModel, NavigationService<InstruktoriListingViewModel> instruktoriListingViewNavigationService)
        {
            _dashboardViewModel = dashboardViewModel;
            _instruktoriListingViewNavigationService = instruktoriListingViewNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return _dashboardViewModel.CanNavigateToInstruktori;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                _instruktoriListingViewNavigationService.Navigate(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
