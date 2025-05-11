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
        private bool _isLoaded;
        public bool IsLoaded
        {
            get { return _isLoaded; }
            set { _isLoaded = value; OnPropertyChanged(nameof(IsLoaded)); }
        }

        public NavigateToInstruktoriCommand NavigateToInstruktoriCommand { get; }
        public ICommand NavigateToIspitiCommand { get; }
        public NavigateToStudentiCommand NavigateToStudentiCommand { get; }
        public NavigateToUplateCommand NavigateToUplateCommand { get; }
        public NavigateToVoznjeCommand NavigateToVoznjeCommand { get; }

        public bool CanNavigateToInstruktori => true;
        public bool CanNavigateToIspiti { get; set; }
        public bool CanNavigateToStudenti => true;
        public bool CanNavigateToUplate => true;
        public bool CanNavigateToVoznje => true;

        public void Initialize(Type korisnikType)
        {
            if (korisnikType is Administrator)
            {
               
                CanNavigateToIspiti = true;
            }
            else if (korisnikType is Instruktor)
            {

                CanNavigateToIspiti = true;
            }
            else if (korisnikType is Student)
            {

                CanNavigateToIspiti = true;
            }

            OnPropertyChanged(nameof(CanNavigateToInstruktori));
            OnPropertyChanged(nameof(CanNavigateToIspiti));
            OnPropertyChanged(nameof(CanNavigateToStudenti));
            OnPropertyChanged(nameof(CanNavigateToUplate));
            OnPropertyChanged(nameof(CanNavigateToVoznje));
        }

        public void LoadViewModel()
        {
            throw new NotImplementedException();
        }

        public DashboardViewModel(NavigationService<InstruktoriListingViewModel> instruktoriNavigationService, NavigationService<StudentiListingViewModel> studentiNavigationService, NavigationService<UplateListingViewModel> uplateNavigationService, NavigationService<VoznjeListingViewModel> voznjeNavigationService)
        {
            NavigateToInstruktoriCommand = new NavigateToInstruktoriCommand(this, instruktoriNavigationService);
            NavigateToIspitiCommand = null;
            NavigateToStudentiCommand = new NavigateToStudentiCommand(this, studentiNavigationService);
            NavigateToUplateCommand = new NavigateToUplateCommand(this, uplateNavigationService);
            NavigateToVoznjeCommand = new NavigateToVoznjeCommand(this, voznjeNavigationService);
        }
    }
}
