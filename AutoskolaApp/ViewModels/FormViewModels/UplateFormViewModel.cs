using AutoskolaApp.Commands;
using AutoskolaApp.Commands.CreationalCommands;
using AutoskolaApp.Commands.EditCommands;
using AutoskolaApp.Commands.SearchCommands;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.ListingViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoskolaApp.ViewModels.FormViewModels
{
    public class UplateFormViewModel : ViewModelBase, ILoadable
    {
        private readonly ObservableCollection<string> _naciniUplate = new ObservableCollection<string> { "Karta", "Gotovina" };
        public IEnumerable<string> NaciniUplate => _naciniUplate;

        private readonly ObservableCollection<StudentViewModel> _studenti;
        public IEnumerable<StudentViewModel> Studenti => _studenti;
        private StudentViewModel _selectedStudent;
        public StudentViewModel SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
                _uplata.IDStudenta = value.IDStudenta;
            }
        }

        private Uplata _uplata;
        public Uplata Uplata
        {
            get { return _uplata; }
            set 
            { 
                _uplata = value; 
                OnPropertyChanged(nameof(Uplata)); 
            }
        }

        private DateTime _datumUplate = DateTime.Now;
        public DateTime DatumUplate
        {
            get { return _datumUplate; }
            set 
            { 
                _datumUplate = value; 
                OnPropertyChanged(nameof(DatumUplate)); 
                _uplata.DatumUplate = value;
            }
        }

        private string _iznos;
        public string Iznos
        {
            get { return _iznos; }
            set 
            { 
                _iznos = value; 
                OnPropertyChanged(nameof(Iznos)); 
                _uplata.Iznos = decimal.Parse(value);
            }
        }

        private string _nacinUplate;
        public string NacinUplate
        {
            get { return _nacinUplate; }
            set 
            { 
                _nacinUplate = value; 
                OnPropertyChanged(nameof(NacinUplate)); 
                _uplata.NacinUplate = value;
            }
        }

        private string _imeStudenta;
        public string ImeStudenta
        {
            get { return _imeStudenta; }
            set 
            { 
                _imeStudenta = value; 
                OnPropertyChanged(nameof(ImeStudenta)); 
            }
        }

        private string _prezimeStudenta;
        public string PrezimeStudenta
        {
            get { return _prezimeStudenta; }
            set 
            { 
                _prezimeStudenta = value; 
                OnPropertyChanged(nameof(PrezimeStudenta)); 
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
        public ICommand SearchCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public UplateFormViewModel(StudentService studentService, UplataService uplataService, NavigationService<UplateListingViewModel> uplateListingViewModelNavigationService)
        {
            SubmitCommand = new CreateUplataCommand(this, studentService, uplataService, uplateListingViewModelNavigationService);
            CancelCommand = new NavigateCommand<UplateListingViewModel>(uplateListingViewModelNavigationService, null);
            EditCommand = new EditUplataCommand(this, uplataService, uplateListingViewModelNavigationService);
            SearchCommand = new KorisnikSearchCommand(this, studentService);
            _studenti = new ObservableCollection<StudentViewModel>();
            _uplata = new Uplata();
            _isEditMode = false;
        }

        public void StudentFound(IEnumerable<Student> studenti)
        {
            _studenti.Clear();

            foreach (Student student in studenti)
            {
                StudentViewModel studentViewModel = new StudentViewModel(student);
                _studenti.Add(studentViewModel);
            }
        }

        public void LoadViewModel(object parameter)
        {
            if (parameter != null)
            {
                UplataViewModel uplata = (UplataViewModel)parameter;
                DatumUplate = uplata.DatumUplate;
                Iznos = uplata.Iznos.ToString();
                NacinUplate = uplata.NacinUplate;
                _uplata.IDUplate = uplata.IDUplate;
                _uplata.DatumUplate = uplata.DatumUplate;
                _uplata.Iznos = uplata.Iznos;
                _uplata.NacinUplate = uplata.NacinUplate;
                _uplata.IDStudenta = uplata.IDStudenta;
                _isEditMode = true;
            }
            else
            {
                _isEditMode = false;
            }
        }
    }
}
