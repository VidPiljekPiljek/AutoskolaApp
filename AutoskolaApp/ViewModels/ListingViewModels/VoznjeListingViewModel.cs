using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Commands;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.FormViewModels;
using System.Windows.Input;
using AutoskolaApp.Commands.DeletionCommands;
using AutoskolaApp.Stores;

namespace AutoskolaApp.ViewModels.ListingViewModels
{
    public class VoznjeListingViewModel : ViewModelBase, ILoadable
    {
        private readonly VoznjaService _voznjaService;
        private readonly ObservableCollection<VoznjaViewModel> _voznje;
        public IEnumerable<VoznjaViewModel> Voznje => _voznje;
        private VoznjaViewModel _selectedVoznja;
        public VoznjaViewModel SelectedVoznja
        {
            get { return _selectedVoznja; }
            set
            {
                _selectedVoznja = value;
                OnPropertyChanged(nameof(SelectedVoznja));
            }
        }
        public ICommand LoadVoznjeCommand { get; }
        public ICommand CreateVoznjaCommand { get; }
        public ICommand NatragCommand { get; }
        public ICommand DeleteSelectionCommand { get; }

        public VoznjeListingViewModel(VoznjaService voznjaService, VoznjaStore voznjaStore, NavigationService<VoznjeFormViewModel> voznjaFormNavigationService, NavigationService<DashboardViewModel> dashboardNavigationService) // TO DO: ADD NAVIGATION SERVICE
        {
            _voznjaService = voznjaService;
            _voznje = new ObservableCollection<VoznjaViewModel>();

            LoadVoznjeCommand = new LoadVoznjeCommand(this, voznjaStore);
            CreateVoznjaCommand = new NavigateCommand<VoznjeFormViewModel>(voznjaFormNavigationService);
            NatragCommand = new NavigateCommand<DashboardViewModel>(dashboardNavigationService);
            DeleteSelectionCommand = new DeleteVoznjaCommand(this, voznjaService);
        }

        //public static InstruktoriListingViewModel LoadViewModel(InstruktorService instruktorService, NavigationService<KorisnikFormViewModel> korisnikFormNavigationService)
        //{
        //    InstruktoriListingViewModel instruktoriPageViewModel = new InstruktoriListingViewModel(instruktorService, korisnikFormNavigationService);

        //    instruktoriPageViewModel.LoadInstruktoriCommand.Execute(null);

        //    return instruktoriPageViewModel;
        //}

        public void UpdateReservations(IEnumerable<Voznja> voznje)
        {
            _voznje.Clear();

            foreach (Voznja voznja in voznje)
            {
                VoznjaViewModel voznjaViewModel = new VoznjaViewModel(voznja);
                _voznje.Add(voznjaViewModel);
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
            LoadVoznjeCommand.Execute(null);
        }
    }
}
