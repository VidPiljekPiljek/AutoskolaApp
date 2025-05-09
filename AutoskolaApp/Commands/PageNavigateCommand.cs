using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels;

namespace AutoskolaApp.Commands
{
    public class PageNavigateCommand<TViewModel> : CommandBase where TViewModel : ViewModelBase
    {
        private readonly PageNavigationService<TViewModel> _pageNavigationService;

        public PageNavigateCommand(PageNavigationService<TViewModel> pageNavigationService)
        {
            _pageNavigationService = pageNavigationService;
        }

        public override void Execute(object? parameter)
        {
            _pageNavigationService.Navigate();
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
