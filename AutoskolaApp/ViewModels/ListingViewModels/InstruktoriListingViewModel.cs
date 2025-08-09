using AutoskolaApp.Commands;
using AutoskolaApp.Commands.DeletionCommands;
using AutoskolaApp.Commands.EditCommands;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels.FormViewModels;
using AutoskolaApp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoskolaApp.ViewModels.ListingViewModels
{
    public class InstruktoriListingViewModel : ViewModelBase, ILoadable
    {
        private readonly InstruktorService _instruktorService;
        private readonly ObservableCollection<InstruktorViewModel> _instruktori;
        public IEnumerable<InstruktorViewModel> Instruktori => _instruktori;

        private InstruktorViewModel _selectedInstruktor;
        public InstruktorViewModel SelectedInstruktor
        {
            get { return _selectedInstruktor; }
            set
            {
                _selectedInstruktor = value;
                OnPropertyChanged(nameof(SelectedInstruktor));
                EditInstruktorCommand.Parameter = _selectedInstruktor;
            }
        }

        public ICommand LoadInstruktoriCommand { get; }
        public ICommand CreateInstruktorCommand { get; }
        public ICommand NavigateBackCommand { get; }
        public ICommand DeleteSelectionCommand { get; }
        public NavigateCommand<InstruktoriFormViewModel> EditInstruktorCommand { get; }
        public bool IsLoaded { get; set; }

        public InstruktoriListingViewModel(InstruktorService instruktorService, InstruktorStore instruktorStore, KorisnikService korisnikService, NavigationService<InstruktoriFormViewModel> instruktorFormNavigationService, NavigationService<DashboardViewModel> dashboardNavigationService) // TO DO: ADD NAVIGATION SERVICE
        {
            _instruktorService = instruktorService;
            _instruktori = new ObservableCollection<InstruktorViewModel>();
            _selectedInstruktor = new InstruktorViewModel();
            IsLoaded = false;
            LoadInstruktoriCommand = new LoadInstruktoriCommand(this, instruktorStore);
            CreateInstruktorCommand = new NavigateCommand<InstruktoriFormViewModel>(instruktorFormNavigationService, null);
            EditInstruktorCommand = new NavigateCommand<InstruktoriFormViewModel>(instruktorFormNavigationService, SelectedInstruktor);
            NavigateBackCommand = new NavigateCommand<DashboardViewModel>(dashboardNavigationService, null);
            DeleteSelectionCommand = new DeleteInstruktorCommand(this, instruktorService, korisnikService);
        }

        //public static InstruktoriListingViewModel LoadViewModel(InstruktorService instruktorService, NavigationService<KorisnikFormViewModel> korisnikFormNavigationService)
        //{
        //    InstruktoriListingViewModel instruktoriPageViewModel = new InstruktoriListingViewModel(instruktorService, korisnikFormNavigationService);

        //    instruktoriPageViewModel.LoadInstruktoriCommand.Execute(null);

        //    return instruktoriPageViewModel;
        //}

        public void UpdateInstruktori(IEnumerable<Instruktor> instruktori)
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

        public void LoadViewModel(object parameter)
        {
            LoadInstruktoriCommand.Execute(null);
            IsLoaded = true;
        }
    }
}
