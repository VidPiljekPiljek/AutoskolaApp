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
    public class IspitiListingViewModel : ViewModelBase
    {
        private readonly IspitService _ispitService;
        private readonly ObservableCollection<IspitViewModel> _ispiti;
        public IEnumerable<IspitViewModel> Ispiti => _ispiti;

        public ICommand LoadInstruktoriCommand { get; }
        public ICommand CreateInstruktorCommand { get; }

        public IspitiListingViewModel(IspitService ispitService, NavigationService<KorisnikFormViewModel> korisnikFormNavigationService) // TO DO: ADD NAVIGATION SERVICE
        {
            _ispitService = ispitService;
            _ispiti = new ObservableCollection<IspitViewModel>();

            LoadInstruktoriCommand = new LoadIspitiCommand(null, _ispitService);
            CreateInstruktorCommand = new NavigateCommand<KorisnikFormViewModel>(korisnikFormNavigationService);
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
            LoadInstruktoriCommand.Execute(null);
        }
    }
}
