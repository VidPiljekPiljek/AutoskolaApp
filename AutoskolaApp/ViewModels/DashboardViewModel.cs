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
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels.PageViewModels.Administrator;
using Wpf.Ui.Abstractions.Controls;
using Wpf.Ui.Controls;
using Wpf.Ui.Input;

namespace AutoskolaApp.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        private readonly PageNavigationStore _pageNavigationStore;

        public ViewModelBase CurrentPageViewModel => _pageNavigationStore.CurrentPageViewModel;

        public PageNavigateCommand<InstruktoriPageViewModel> InstruktoriCommand { get; }
        public ICommand IspitiCommand { get; }
        public ICommand StudentiCommand { get; }
        public ICommand UplateCommand { get; }
        public ICommand VoznjeCommand { get; }

        public bool CanNavigateToInstruktori { get; set; }
        public bool CanNavigateToIspiti { get; set; }
        public bool CanNavigateToStudenti { get; set; }
        public bool CanNavigateToUplate { get; set; }
        public bool CanNavigateToVoznje { get; set; }

        public void Initialize(Type korisnikType)
        {
            if (korisnikType is Administrator)
            {
                CanNavigateToInstruktori = true;
                CanNavigateToIspiti = true;
                CanNavigateToStudenti = true;
                CanNavigateToUplate = true;
                CanNavigateToVoznje = true;
            }
            else if (korisnikType is Instruktor)
            {
                CanNavigateToInstruktori = false;
                CanNavigateToIspiti = true;
                CanNavigateToStudenti = false;
                CanNavigateToUplate = false;
                CanNavigateToVoznje = true;
            }
            else if (korisnikType is Student)
            {
                CanNavigateToInstruktori = false;
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

        public DashboardViewModel(PageNavigationStore pageNavigationStore, PageNavigationService<InstruktoriPageViewModel> instruktoriNavigationService)
        {
            _pageNavigationStore = pageNavigationStore;
            InstruktoriCommand = new PageNavigateCommand<InstruktoriPageViewModel>(instruktoriNavigationService);
            IspitiCommand = null;
            StudentiCommand = null;
            UplateCommand = null;
            VoznjeCommand = null;
        }
    }
}
