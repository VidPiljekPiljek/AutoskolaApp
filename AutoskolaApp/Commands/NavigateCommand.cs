using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels;

namespace AutoskolaApp.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase where TViewModel : ViewModelBase
    {
        private readonly NavigationService<TViewModel> _navigationService;
        private object _parameter;
        public object Parameter
        {
            get => _parameter;
            set => _parameter = value;
        }


        public NavigateCommand(NavigationService<TViewModel> navigationService, object parameter)
        {
            _navigationService = navigationService;
            _parameter = parameter;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate(_parameter);
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
