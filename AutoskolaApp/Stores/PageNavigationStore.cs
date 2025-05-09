using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using AutoskolaApp.ViewModels;

namespace AutoskolaApp.Stores
{
    public class PageNavigationStore
    {
        private ViewModelBase _currentPageViewModel;
        public ViewModelBase CurrentPageViewModel
        {
            get { return _currentPageViewModel; }
            set
            {
                _currentPageViewModel?.Dispose();
                _currentPageViewModel = value;
                OnCurrentPageViewModelChanged();
            }
        }

        public event Action CurrentPageViewModelChanged;

        private void OnCurrentPageViewModelChanged()
        {
            CurrentPageViewModelChanged?.Invoke();
        }
    }
}
