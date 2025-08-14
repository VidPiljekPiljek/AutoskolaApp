using AutoskolaApp.Commands;
using AutoskolaApp.Commands.CreationalCommands;
using AutoskolaApp.Commands.DeletionCommands;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.Stores;
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
    public class IspitiListingViewModel : ViewModelBase, ILoadable
    {
        private readonly IspitService _ispitService;
        private readonly ObservableCollection<IspitViewModel> _ispiti;
        public IEnumerable<IspitViewModel> Ispiti => _ispiti;
        private IspitViewModel _selectedIspit;
        public IspitViewModel SelectedIspit
        {
            get { return _selectedIspit; }
            set
            {
                _selectedIspit = value;
                OnPropertyChanged(nameof(SelectedIspit));
                EditIspitCommand.Parameter = _selectedIspit;
            }
        }
        public ICommand LoadIspitiCommand { get; }
        public ICommand CreateIspitCommand { get; }
        public ICommand NavigateBackCommand { get; }
        public ICommand DeleteSelectionCommand { get; }
        public NavigateCommand<IspitiFormViewModel> EditIspitCommand { get; }
        public bool IsLoaded { get; set; }

        public IspitiListingViewModel(IspitService ispitService, IspitStore ispitStore, NavigationService<IspitiFormViewModel> ispitiFormNavigationService, NavigationService<DashboardViewModel> dashboardNavigationService) // TO DO: ADD NAVIGATION SERVICE
        {
            _ispitService = ispitService;
            _ispiti = new ObservableCollection<IspitViewModel>();
            _selectedIspit = new IspitViewModel();
            IsLoaded = false;
            LoadIspitiCommand = new LoadIspitiCommand(this, ispitStore);
            CreateIspitCommand = new NavigateCommand<IspitiFormViewModel>(ispitiFormNavigationService, null);
            EditIspitCommand = new NavigateCommand<IspitiFormViewModel>(ispitiFormNavigationService, SelectedIspit);
            NavigateBackCommand = new NavigateCommand<DashboardViewModel>(dashboardNavigationService, null);
            DeleteSelectionCommand = new DeleteIspitCommand(this, ispitService);
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

        public void LoadViewModel(object parameter)
        {
            LoadIspitiCommand.Execute(null);
            IsLoaded = true;
        }
    }
}
