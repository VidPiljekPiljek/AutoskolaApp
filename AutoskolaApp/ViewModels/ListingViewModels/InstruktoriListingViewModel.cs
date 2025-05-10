using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Commands;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using System.Windows.Input;
using AutoskolaApp.Views.Forms;
using AutoskolaApp.ViewModels.FormViewModels;

namespace AutoskolaApp.ViewModels.ListingViewModels
{
    public class InstruktoriListingViewModel : ViewModelBase
    {
        private readonly InstruktorService _instruktorService;
        private readonly ObservableCollection<InstruktorViewModel> _instruktori;
        public IEnumerable<InstruktorViewModel> Instruktori => _instruktori;

        public ICommand LoadInstruktoriCommand { get; }
        public ICommand CreateInstruktorCommand { get; }

        public InstruktoriListingViewModel(InstruktorService instruktorService, NavigationService<KorisnikFormViewModel> korisnikFormNavigationService) // TO DO: ADD NAVIGATION SERVICE
        {
            _instruktorService = instruktorService;
            _instruktori = new ObservableCollection<InstruktorViewModel>();

            LoadInstruktoriCommand = new LoadInstruktoriCommand(this, _instruktorService);
            CreateInstruktorCommand = new NavigateCommand<KorisnikFormViewModel>(korisnikFormNavigationService);
        }

        public static InstruktoriListingViewModel LoadViewModel(InstruktorService instruktorService, NavigationService<KorisnikFormViewModel> korisnikFormNavigationService)
        {
            InstruktoriListingViewModel instruktoriPageViewModel = new InstruktoriListingViewModel(instruktorService, korisnikFormNavigationService);

            instruktoriPageViewModel.LoadInstruktoriCommand.Execute(null);

            return instruktoriPageViewModel;
        }

        public void UpdateReservations(IEnumerable<Instruktor> instruktori)
        {
            _instruktori.Clear();

            foreach (Instruktor instruktor in instruktori)
            {
                InstruktorViewModel instruktorViewModel = new InstruktorViewModel(instruktor);
                _instruktori.Add(instruktorViewModel);
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
    }
}
