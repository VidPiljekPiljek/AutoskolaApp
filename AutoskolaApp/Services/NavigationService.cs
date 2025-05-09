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
            _navigationStore.CurrentViewModel = viewModel;
        }

        public void NavigateWithCallback(Action<TViewModel> callback)
        {
            var viewModel = _createViewModel();
            callback(viewModel);
            _navigationStore.CurrentViewModel = viewModel;
        }
    }
}
