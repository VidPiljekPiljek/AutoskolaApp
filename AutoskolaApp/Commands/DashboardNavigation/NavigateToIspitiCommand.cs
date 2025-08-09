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
    public class NavigateToIspitiCommand : AsyncCommandBase
    {
        private readonly DashboardViewModel _dashboardViewModel;
        private readonly NavigationService<IspitiListingViewModel> _ispitiListingViewNavigationService;

        public NavigateToIspitiCommand(DashboardViewModel dashboardViewModel, NavigationService<IspitiListingViewModel> ispitiListingViewNavigationService)
        {
            _dashboardViewModel = dashboardViewModel;
            _ispitiListingViewNavigationService = ispitiListingViewNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return _dashboardViewModel.CanNavigateToInstruktori;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                _ispitiListingViewNavigationService.Navigate(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
