using AutoskolaApp.Commands;
using AutoskolaApp.Commands.DeletionCommands;
using AutoskolaApp.Commands.EditCommands;
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
    public class UplateListingViewModel : ViewModelBase, ILoadable
    {
        private readonly UplataService _uplataService;
        private readonly ObservableCollection<UplataViewModel> _uplate;
        public IEnumerable<UplataViewModel> Uplate => _uplate;
        private UplataViewModel _selectedUplata;
        public UplataViewModel SelectedUplata
        {
            get { return _selectedUplata; }
            set
            {
                _selectedUplata = value;
                OnPropertyChanged(nameof(SelectedUplata));
                EditUplataCommand.Parameter = _selectedUplata;
            }
        }
        public ICommand LoadUplateCommand { get; }
        public ICommand CreateUplataCommand { get; }
        public ICommand NavigateBackCommand { get; }
        public ICommand DeleteSelectionCommand { get; }
        public NavigateCommand<UplateFormViewModel> EditUplataCommand { get; }

        public UplateListingViewModel(UplataService uplataService, UplataStore uplataStore, NavigationService<UplateFormViewModel> uplateFormNavigationService, NavigationService<DashboardViewModel> dashboardNavigationService) // TO DO: ADD NAVIGATION SERVICE
        {
            _uplataService = uplataService;
            _uplate = new ObservableCollection<UplataViewModel>();
            
            _selectedUplata = new UplataViewModel();
            LoadUplateCommand = new LoadUplateCommand(this, uplataStore);
            CreateUplataCommand = new NavigateCommand<UplateFormViewModel>(uplateFormNavigationService, null);
            EditUplataCommand = new NavigateCommand<UplateFormViewModel>(uplateFormNavigationService, SelectedUplata);
            NavigateBackCommand = new NavigateCommand<DashboardViewModel>(dashboardNavigationService, null);
            DeleteSelectionCommand = new DeleteUplateCommand(this, uplataService);
        }

        //public static InstruktoriListingViewModel LoadViewModel(InstruktorService instruktorService, NavigationService<KorisnikFormViewModel> korisnikFormNavigationService)
        //{
        //    InstruktoriListingViewModel instruktoriPageViewModel = new InstruktoriListingViewModel(instruktorService, korisnikFormNavigationService);

        //    instruktoriPageViewModel.LoadInstruktoriCommand.Execute(null);

        //    return instruktoriPageViewModel;
        //}

        public void UpdateReservations(IEnumerable<Uplata> uplate)
        {
            _uplate.Clear();

            foreach (Uplata uplata in uplate)
            {
                UplataViewModel uplataViewModel = new UplataViewModel(uplata);
                _uplate.Add(uplataViewModel);
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
            LoadUplateCommand.Execute(null);
        }
    }
}
