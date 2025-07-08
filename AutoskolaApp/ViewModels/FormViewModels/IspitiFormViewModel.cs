using AutoskolaApp.Commands;
using AutoskolaApp.Commands.CreationalCommands;
using AutoskolaApp.Commands.SearchCommands;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.ListingViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoskolaApp.ViewModels.FormViewModels
{
    public class IspitiFormViewModel : ViewModelBase
    {
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
            }
        }
        private DateTime _dateTime;
        public DateTime DateTime
        {
            get { return _dateTime; }
            set
            {
                _dateTime = value;
                OnPropertyChanged(nameof(DateTime));
            }
        }
        private string _vrstaIspita;
        public string VrstaIspita
        {
            get { return _vrstaIspita; }
            set
            {
                _vrstaIspita = value;
                OnPropertyChanged(nameof(VrstaIspita));
            }
        }
        private int _idInstruktora;

        public int IDInstruktora
        {
            get { return _idInstruktora; }
            set
            {
                _idInstruktora = value;
                OnPropertyChanged(nameof(IDInstruktora));
            }
        }

        private string _imeInstruktora;
        public string ImeInstruktora
        {
            get { return _imeInstruktora; }
            set { _imeInstruktora = value; OnPropertyChanged(nameof(ImeInstruktora)); }
        }

        private string _prezimeInstruktora;
        public string PrezimeInstruktora
        {
            get { return _prezimeInstruktora; }
            set { _prezimeInstruktora = value; OnPropertyChanged(nameof(PrezimeInstruktora)); }
        }

        public AsyncCommandBase SubmitCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public IspitiFormViewModel(IspitService ispitService, InstruktorService instruktorService, NavigationService<IspitiListingViewModel> ispitiListingViewModelNavigationService)
        {
            SubmitCommand = new CreateIspitCommand(this, ispitService, ispitiListingViewModelNavigationService);
            CancelCommand = new NavigateCommand<IspitiListingViewModel>(ispitiListingViewModelNavigationService);
            SearchCommand = new InstruktorSearchCommand(this, instruktorService);
            _instruktori = new ObservableCollection<InstruktorViewModel>();
        }

        public void InstruktorFound(IEnumerable<Instruktor> instruktori)
        {
            _instruktori.Clear();

            foreach (Instruktor instruktor in instruktori)
            {
                InstruktorViewModel instruktorViewModel = new InstruktorViewModel(instruktor);
                _instruktori.Add(instruktorViewModel);
            }
        }
    }
}
