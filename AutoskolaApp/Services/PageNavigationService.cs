using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels;

namespace AutoskolaApp.Services
{
    public class PageNavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        private readonly PageNavigationStore _pageNavigationStore;
        private readonly Func<TViewModel> _createViewModel;

        public PageNavigationService(PageNavigationStore pageNavigationStore, Func<TViewModel> createViewModel)
        {
            _pageNavigationStore = pageNavigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            var viewModel = _createViewModel();
            _pageNavigationStore.CurrentPageViewModel = viewModel;
        }
    }
}
