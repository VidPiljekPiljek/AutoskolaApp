using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AutoskolaApp.Commands;
using AutoskolaApp.Commands.CreationalCommands;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.ListingViewModels;

namespace AutoskolaApp.ViewModels.FormViewModels
{
    public class InstruktoriFormViewModel : ViewModelBase
    {
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
            }
        }

        private DateTime _datumPocetka;
        public DateTime DatumPocetka
        {
            get { return _datumPocetka; }
            set
            {
                _datumPocetka = value;
                OnPropertyChanged(nameof(DatumPocetka));
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
            }
        }

        public AsyncCommandBase SubmitCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public InstruktoriFormViewModel(KorisnikService korisnikService, InstruktorService instruktorService, NavigationService<InstruktoriListingViewModel> instruktoriNavigationService)
        {
            SubmitCommand = new CreateInstruktorCommand(this, korisnikService, instruktorService, instruktoriNavigationService);
            CancelCommand = new NavigateCommand<InstruktoriListingViewModel>(instruktoriNavigationService);
        }
    }
}
