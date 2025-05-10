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
    public class DashboardViewModel : ViewModelBase
    {
        public NavigateToInstruktoriCommand NavigateToInstruktoriCommand { get; }
        public ICommand IspitiCommand { get; }
        public ICommand StudentiCommand { get; }
        public ICommand UplateCommand { get; }
        public ICommand VoznjeCommand { get; }

        public bool CanNavigateToInstruktori => true;
        public bool CanNavigateToIspiti { get; set; }
        public bool CanNavigateToStudenti { get; set; }
        public bool CanNavigateToUplate { get; set; }
        public bool CanNavigateToVoznje { get; set; }

        public void Initialize(Type korisnikType)
        {
            if (korisnikType is Administrator)
            {
               
                CanNavigateToIspiti = true;
                CanNavigateToStudenti = true;
                CanNavigateToUplate = true;
                CanNavigateToVoznje = true;
            }
            else if (korisnikType is Instruktor)
            {

                CanNavigateToIspiti = true;
                CanNavigateToStudenti = false;
                CanNavigateToUplate = false;
                CanNavigateToVoznje = true;
            }
            else if (korisnikType is Student)
            {

                CanNavigateToIspiti = true;
                CanNavigateToStudenti = false;
                CanNavigateToUplate = true;
                CanNavigateToVoznje = true;
            }

            OnPropertyChanged(nameof(CanNavigateToInstruktori));
            OnPropertyChanged(nameof(CanNavigateToIspiti));
            OnPropertyChanged(nameof(CanNavigateToStudenti));
            OnPropertyChanged(nameof(CanNavigateToUplate));
            OnPropertyChanged(nameof(CanNavigateToVoznje));
        }

        public DashboardViewModel(NavigationService<InstruktoriListingViewModel> instruktoriNavigationService)
        {
            NavigateToInstruktoriCommand = new NavigateToInstruktoriCommand(this, instruktoriNavigationService);
            IspitiCommand = null;
            StudentiCommand = null;
            UplateCommand = null;
            VoznjeCommand = null;
        }
    }
}
