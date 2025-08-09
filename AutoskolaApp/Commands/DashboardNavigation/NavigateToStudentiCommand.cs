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
    public class NavigateToStudentiCommand : AsyncCommandBase
    {
        private readonly DashboardViewModel _dashboardViewModel;
        private readonly NavigationService<StudentiListingViewModel> _studentiListingViewNavigationService;

        public NavigateToStudentiCommand(DashboardViewModel dashboardViewModel, NavigationService<StudentiListingViewModel> studentiListingViewNavigationService)
        {
            _dashboardViewModel = dashboardViewModel;
            _studentiListingViewNavigationService = studentiListingViewNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return _dashboardViewModel.CanNavigateToStudenti;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                _studentiListingViewNavigationService.Navigate(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
