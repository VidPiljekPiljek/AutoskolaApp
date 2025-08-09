using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.ListingViewModels;
using AutoskolaApp.ViewModels;
using System.Windows;

namespace AutoskolaApp.Commands.DashboardNavigation
{
    public class NavigateToUplateCommand : AsyncCommandBase
    {
        private readonly DashboardViewModel _dashboardViewModel;
        private readonly NavigationService<UplateListingViewModel> _uplateListingViewNavigationService;

        public NavigateToUplateCommand(DashboardViewModel dashboardViewModel, NavigationService<UplateListingViewModel> uplateListingViewNavigationService)
        {
            _dashboardViewModel = dashboardViewModel;
            _uplateListingViewNavigationService = uplateListingViewNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return _dashboardViewModel.CanNavigateToUplate;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                _uplateListingViewNavigationService.Navigate(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
