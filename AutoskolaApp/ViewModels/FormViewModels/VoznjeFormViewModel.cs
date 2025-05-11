using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AutoskolaApp.Commands;
using AutoskolaApp.Commands.CreationalCommands;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.ListingViewModels;

namespace AutoskolaApp.ViewModels.FormViewModels
{
    public class VoznjeFormViewModel : ViewModelBase
    {
        private DateTime _datumVoznje;
        public DateTime DatumVoznje
        {
            get { return _datumVoznje; }
            set { _datumVoznje = value; OnPropertyChanged(nameof(DatumVoznje)); }
        }

        private string _studentIme;
        public string StudentIme
        {
            get { return _studentIme; }
            set { _studentIme = value; OnPropertyChanged(nameof(StudentIme)); }
        }

        private string _studentPrezime;
        public string StudentPrezime
        {
            get { return _studentPrezime; }
            set { _studentPrezime = value; OnPropertyChanged(nameof(StudentPrezime)); }
        }

        private string _instruktorIme;
        public string InstruktorIme
        {
            get { return _instruktorIme; }
            set { _instruktorIme = value; OnPropertyChanged(nameof(InstruktorIme)); }
        }

        private string _instruktorPrezime;
        public string InstruktorPrezime
        {
            get { return _instruktorPrezime; }
            set { _instruktorPrezime = value; OnPropertyChanged(nameof(InstruktorPrezime)); }
        }

        public AsyncCommandBase SubmitCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public VoznjeFormViewModel(StudentService studentService, InstruktorService instruktorService, VoznjaService voznjaService, NavigationService<VoznjeListingViewModel> voznjeNavigationService) {
            SubmitCommand = new CreateVoznjaCommand(this, studentService, instruktorService, voznjaService, voznjeNavigationService);
            CancelCommand = new NavigateCommand<VoznjeListingViewModel>(voznjeNavigationService);
        }
    }
}
