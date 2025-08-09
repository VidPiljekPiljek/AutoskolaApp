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
    public class NavigateToVoznjeCommand : AsyncCommandBase
    {
        private readonly DashboardViewModel _dashboardViewModel;
        private readonly NavigationService<VoznjeListingViewModel> _voznjeListingViewNavigationService;

        public NavigateToVoznjeCommand(DashboardViewModel dashboardViewModel, NavigationService<VoznjeListingViewModel> voznjeListingViewNavigationService)
        {
            _dashboardViewModel = dashboardViewModel;
            _voznjeListingViewNavigationService = voznjeListingViewNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return _dashboardViewModel.CanNavigateToVoznje;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                _voznjeListingViewNavigationService.Navigate(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
