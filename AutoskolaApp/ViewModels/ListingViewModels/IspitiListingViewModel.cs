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
    public class IspitiListingViewModel
    {
        private readonly InstruktorService _instruktorService;
        private readonly ObservableCollection<InstruktorViewModel> _instruktori;
        public IEnumerable<InstruktorViewModel> Instruktori => _instruktori;

        public ICommand LoadInstruktoriCommand { get; }
        public ICommand CreateInstruktorCommand { get; }

        public IspitiListingViewModel(InstruktorService instruktorService, NavigationService<KorisnikFormViewModel> korisnikFormNavigationService) // TO DO: ADD NAVIGATION SERVICE
        {
            _instruktorService = instruktorService;
            _instruktori = new ObservableCollection<InstruktorViewModel>();

            LoadInstruktoriCommand = new LoadInstruktoriCommand(null, _instruktorService);
            CreateInstruktorCommand = new NavigateCommand<KorisnikFormViewModel>(korisnikFormNavigationService);
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

        public void LoadViewModel()
        {
            LoadInstruktoriCommand.Execute(null);
        }
    }
}
