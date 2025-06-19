using AutoskolaApp.Commands;
using AutoskolaApp.Commands.CreationalCommands;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.FormViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoskolaApp.ViewModels.ListingViewModels
{
    public class IspitiListingViewModel : ViewModelBase
    {
        private readonly IspitService _ispitService;
        private readonly ObservableCollection<IspitViewModel> _ispiti;
        public IEnumerable<IspitViewModel> Ispiti => _ispiti;

        public ICommand LoadIspitiCommand { get; }
        public ICommand CreateIspitCommand { get; }
        public ICommand NavigateBackCommand { get; }

        public IspitiListingViewModel(IspitService ispitService, NavigationService<KorisnikFormViewModel> korisnikFormNavigationService, NavigationService<DashboardViewModel> dashboardNavigationService) // TO DO: ADD NAVIGATION SERVICE
        {
            _ispitService = ispitService;
            _ispiti = new ObservableCollection<IspitViewModel>();

            LoadIspitiCommand = new LoadIspitiCommand(null, _ispitService);
            CreateIspitCommand = new NavigateCommand<KorisnikFormViewModel>(korisnikFormNavigationService);
            NavigateBackCommand = new NavigateCommand<DashboardViewModel>(dashboardNavigationService);
        }

        public void UpdateReservations(IEnumerable<Ispit> ispiti)
        {
            _ispiti.Clear();

            foreach (Ispit ispit in ispiti)
            {
                IspitViewModel ispitViewModel = new IspitViewModel(ispit);
                _ispiti.Add(ispitViewModel);
            }
        }

        public Task OnNavigatedToAsync()
        {
            throw new NotImplementedException();
        }

        public Task OnNavigatedFromAsync()
        {
            throw new NotImplementedException();
        }

        public void LoadViewModel()
        {
            LoadIspitiCommand.Execute(null);
        }
    }
}
