using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels;
using Wpf.Ui.Abstractions.Controls;

namespace AutoskolaApp.Services
{
    public class NavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            var viewModel = _createViewModel();
            if (viewModel is INavigationAware navigationAware)
            {
                navigationAware.OnNavigatedToAsync();
            }
            _navigationStore.CurrentViewModel = viewModel;
        }
    }
}
