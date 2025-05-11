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

namespace AutoskolaApp.ViewModels.ListingViewModels
{
    public class VoznjeListingViewModel : ViewModelBase
    {
        private readonly VoznjaService _voznjaService;
        private readonly ObservableCollection<VoznjaViewModel> _voznje;
        public IEnumerable<VoznjaViewModel> Voznje => _voznje;

        public ICommand LoadVoznjeCommand { get; }
        public ICommand CreateVoznjaCommand { get; }

        public VoznjeListingViewModel(VoznjaService voznjaService, NavigationService<VoznjeFormViewModel> voznjaFormNavigationService) // TO DO: ADD NAVIGATION SERVICE
        {
            _voznjaService = voznjaService;
            _voznje = new ObservableCollection<VoznjaViewModel>();

            LoadVoznjeCommand = new LoadVoznjeCommand(this, voznjaService);
            CreateVoznjaCommand = new NavigateCommand<VoznjeFormViewModel>(voznjaFormNavigationService);
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
