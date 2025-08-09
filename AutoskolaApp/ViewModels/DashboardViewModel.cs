using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;
using AutoskolaApp.Commands;
using AutoskolaApp.Commands.DashboardNavigation;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels.ListingViewModels;
using Wpf.Ui.Abstractions.Controls;
using Wpf.Ui.Controls;
using Wpf.Ui.Input;

namespace AutoskolaApp.ViewModels
{
    public class DashboardViewModel : ViewModelBase, ILoadable
    {
        private readonly KorisnikService _korisnikService;
        private bool _isLoaded;
        public bool IsLoaded
        {
            get { return _isLoaded; }
            set { _isLoaded = value; OnPropertyChanged(nameof(IsLoaded)); }
        }

        public NavigateToInstruktoriCommand NavigateToInstruktoriCommand { get; }
        public NavigateToIspitiCommand NavigateToIspitiCommand { get; }
        public NavigateToStudentiCommand NavigateToStudentiCommand { get; }
        public NavigateToUplateCommand NavigateToUplateCommand { get; }
        public NavigateToVoznjeCommand NavigateToVoznjeCommand { get; }

        public bool CanNavigateToInstruktori { get; set; }
        public bool CanNavigateToIspiti { get; set; }
        public bool CanNavigateToStudenti { get; set; }
        public bool CanNavigateToUplate { get; set; }
        public bool CanNavigateToVoznje { get; set; }

        public void LoadViewModel()
        {
            Type tipKorisnika = _korisnikService.KorisnikAuthorization();
            Console.WriteLine($"User role: {tipKorisnika}");
            if (tipKorisnika == typeof(Administrator))
            {
                CanNavigateToInstruktori = true;
                OnPropertyChanged(nameof(CanNavigateToInstruktori));
                CanNavigateToIspiti = true;
                OnPropertyChanged(nameof(CanNavigateToIspiti));
                CanNavigateToStudenti = true;
                OnPropertyChanged(nameof(CanNavigateToStudenti));
                CanNavigateToUplate = true;
                OnPropertyChanged(nameof(CanNavigateToUplate));
                CanNavigateToVoznje = true;
                OnPropertyChanged(nameof(CanNavigateToVoznje));
            }
            else if (tipKorisnika == typeof(Instruktor))
            {
                CanNavigateToInstruktori = false;
                OnPropertyChanged(nameof(CanNavigateToInstruktori));
                CanNavigateToIspiti = true;
                OnPropertyChanged(nameof(CanNavigateToIspiti));
                CanNavigateToStudenti = false;
                OnPropertyChanged(nameof(CanNavigateToStudenti));
                CanNavigateToUplate = false;
                OnPropertyChanged(nameof(CanNavigateToUplate));
                CanNavigateToVoznje = true;
                OnPropertyChanged(nameof(CanNavigateToVoznje));
            }
            else if (tipKorisnika == typeof(Student))
            {
                CanNavigateToInstruktori = false;
                OnPropertyChanged(nameof(CanNavigateToInstruktori));
                CanNavigateToIspiti = true;
                OnPropertyChanged(nameof(CanNavigateToIspiti));
                CanNavigateToStudenti = false;
                OnPropertyChanged(nameof(CanNavigateToStudenti));
                CanNavigateToUplate = true;
                OnPropertyChanged(nameof(CanNavigateToUplate));
                CanNavigateToVoznje = true;
                OnPropertyChanged(nameof(CanNavigateToVoznje));
            }
        }

        public void LoadViewModel(object parameter)
        {
            Type tipKorisnika = _korisnikService.KorisnikAuthorization();
            Console.WriteLine($"User role: {tipKorisnika}");
            if (tipKorisnika == typeof(Administrator))
            {
                CanNavigateToInstruktori = true;
                OnPropertyChanged(nameof(CanNavigateToInstruktori));
                CanNavigateToIspiti = true;
                OnPropertyChanged(nameof(CanNavigateToIspiti));
                CanNavigateToStudenti = true;
                OnPropertyChanged(nameof(CanNavigateToStudenti));
                CanNavigateToUplate = true;
                OnPropertyChanged(nameof(CanNavigateToUplate));
                CanNavigateToVoznje = true;
                OnPropertyChanged(nameof(CanNavigateToVoznje));
            }
            else if (tipKorisnika == typeof(Instruktor))
            {
                CanNavigateToInstruktori = false;
                OnPropertyChanged(nameof(CanNavigateToInstruktori));
                CanNavigateToIspiti = true;
                OnPropertyChanged(nameof(CanNavigateToIspiti));
                CanNavigateToStudenti = false;
                OnPropertyChanged(nameof(CanNavigateToStudenti));
                CanNavigateToUplate = false;
                OnPropertyChanged(nameof(CanNavigateToUplate));
                CanNavigateToVoznje = true;
                OnPropertyChanged(nameof(CanNavigateToVoznje));
            }
            else if (tipKorisnika == typeof(Student))
            {
                CanNavigateToInstruktori = false;
                OnPropertyChanged(nameof(CanNavigateToInstruktori));
                CanNavigateToIspiti = true;
                OnPropertyChanged(nameof(CanNavigateToIspiti));
                CanNavigateToStudenti = false;
                OnPropertyChanged(nameof(CanNavigateToStudenti));
                CanNavigateToUplate = true;
                OnPropertyChanged(nameof(CanNavigateToUplate));
                CanNavigateToVoznje = true;
                OnPropertyChanged(nameof(CanNavigateToVoznje));
            }
        }

        public DashboardViewModel(KorisnikService korisnikService, NavigationService<InstruktoriListingViewModel> instruktoriNavigationService, NavigationService<IspitiListingViewModel> ispitiNavigationService, NavigationService<StudentiListingViewModel> studentiNavigationService, NavigationService<UplateListingViewModel> uplateNavigationService, NavigationService<VoznjeListingViewModel> voznjeNavigationService)
        {
            _korisnikService = korisnikService;
            NavigateToInstruktoriCommand = new NavigateToInstruktoriCommand(this, instruktoriNavigationService);
            NavigateToIspitiCommand = new NavigateToIspitiCommand(this, ispitiNavigationService);
            NavigateToStudentiCommand = new NavigateToStudentiCommand(this, studentiNavigationService);
            NavigateToUplateCommand = new NavigateToUplateCommand(this, uplateNavigationService);
            NavigateToVoznjeCommand = new NavigateToVoznjeCommand(this, voznjeNavigationService);
        }
    }
}
