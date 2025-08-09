 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using AutoskolaApp.Commands;
using AutoskolaApp.Commands.CreationalCommands;
using AutoskolaApp.Commands.EditCommands;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.ListingViewModels;

namespace AutoskolaApp.ViewModels.FormViewModels
{
    public class InstruktoriFormViewModel : ViewModelBase, ILoadable
    {
        private Instruktor _instruktor;
        public Instruktor Instruktor
        {
            get { return _instruktor; }
            set
            {
                _instruktor = value;
                OnPropertyChanged(nameof(Instruktor));
            }
        }

        private string _korisnickoIme;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set
            {
                _korisnickoIme = value;
                OnPropertyChanged(nameof(KorisnickoIme));
            }
        }

        private string _lozinka;
        public string Lozinka
        {
            get { return _lozinka; }
            set
            {
                _lozinka = value;
                OnPropertyChanged(nameof(Lozinka));
            }
        }

        private string _OIB;
        public string OIB
        {
            get { return _OIB; }
            set
            {
                _OIB = value;
                OnPropertyChanged(nameof(OIB));
                _instruktor.OIB = value;
            }
        }

        private string _ime;
        public string Ime
        {
            get { return _ime; }
            set
            {
                _ime = value;
                OnPropertyChanged(nameof(Ime));
                _instruktor.Ime = value;
            }
        }

        private string _prezime;
        public string Prezime
        {
            get { return _prezime; }
            set
            {
                _prezime = value;
                OnPropertyChanged(nameof(Prezime));
                _instruktor.Prezime = value;
            }
        }

        private DateTime _datumPocetka = DateTime.Now;
        public DateTime DatumPocetka
        {
            get { return _datumPocetka; }
            set
            {
                _datumPocetka = value;
                OnPropertyChanged(nameof(DatumPocetka));
                _instruktor.DatumZaposlenja = value;
            }
        }

        private string _napomena;
        public string Napomena
        {
            get { return _napomena; }
            set
            {
                _napomena = value;
                OnPropertyChanged(nameof(Napomena));
                _instruktor.Napomena = value;
            }
        }

        private bool _isEditMode;
        public bool IsEditMode
        {
            get { return _isEditMode; }
            set
            {
                _isEditMode = value;
                OnPropertyChanged(nameof(IsEditMode));
            }
        }

        public AsyncCommandBase SubmitCommand { get; set; }
        public AsyncCommandBase EditCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public InstruktoriFormViewModel(KorisnikService korisnikService, InstruktorService instruktorService, NavigationService<InstruktoriListingViewModel> instruktoriNavigationService)
        {
            SubmitCommand = new CreateInstruktorCommand(this, korisnikService, instruktorService, instruktoriNavigationService);
            _isEditMode = false;
            EditCommand = new EditInstruktorCommand(this, instruktorService, instruktoriNavigationService);
            CancelCommand = new NavigateCommand<InstruktoriListingViewModel>(instruktoriNavigationService, null);
            _instruktor = new Instruktor();
        }

        public void LoadViewModel(object parameter)
        {
            if (parameter != null)
            {
                InstruktorViewModel instruktor = (InstruktorViewModel)parameter;
                OIB = instruktor.OIB;
                Ime = instruktor.Ime;
                Prezime = instruktor.Prezime;
                DatumPocetka = instruktor.DatumZaposlenja;
                Napomena = instruktor.Napomena;
                _instruktor.IDInstruktora = instruktor.IDInstruktora;
                _instruktor.OIB = instruktor.OIB;
                _instruktor.Ime = instruktor.Ime;
                _instruktor.Prezime = instruktor.Prezime;
                _instruktor.DatumZaposlenja = instruktor.DatumZaposlenja;
                _instruktor.Napomena = instruktor.Napomena;
                _instruktor.IDKorisnika = instruktor.IDKorisnika;
                _isEditMode = true;
            }
            else
            {
                _isEditMode = false;

            }
        }
    }
}
