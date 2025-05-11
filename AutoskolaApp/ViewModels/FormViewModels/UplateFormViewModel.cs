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
    public class UplateFormViewModel : ViewModelBase
    {
        private DateTime _datumUplate;
        public DateTime DatumUplate
        {
            get { return _datumUplate; }
            set { _datumUplate = value; OnPropertyChanged(nameof(DatumUplate)); }
        }

        private decimal _iznos;
        public decimal Iznos
        {
            get { return _iznos; }
            set { _iznos = decimal.Parse(value.ToString()); OnPropertyChanged(nameof(Iznos)); }
        }

        private string _nacinUplate;
        public string NacinUplate
        {
            get { return _nacinUplate; }
            set { _nacinUplate = value; OnPropertyChanged(nameof(NacinUplate)); }
        }

        private string _imeStudenta;
        public string ImeStudenta
        {
            get { return _imeStudenta; }
            set { _imeStudenta = value; OnPropertyChanged(nameof(ImeStudenta)); }
        }

        private string _prezimeStudenta;
        public string PrezimeStudenta
        {
            get { return _prezimeStudenta; }
            set { _prezimeStudenta = value; OnPropertyChanged(nameof(PrezimeStudenta)); }
        }

        public AsyncCommandBase SubmitCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public UplateFormViewModel(StudentService studentService, UplataService uplataService, NavigationService<UplateListingViewModel> uplateListingViewModel)
        {
            SubmitCommand = new CreateUplataCommand(this, studentService, uplataService, uplateListingViewModel);
            CancelCommand = new NavigateCommand<UplateListingViewModel>(uplateListingViewModel);
        }
    }
}
