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
    public class UplateFormViewModel : ViewModelBase
    {
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
            }
        }

        private DateTime _datumUplate = DateTime.Now;
        public DateTime DatumUplate
        {
            get { return _datumUplate; }
            set { _datumUplate = value; OnPropertyChanged(nameof(DatumUplate)); }
        }

        private string _iznos;
        public string Iznos
        {
            get { return _iznos; }
            set { _iznos = value; OnPropertyChanged(nameof(Iznos)); }
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
        public ICommand SearchCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public UplateFormViewModel(StudentService studentService, UplataService uplataService, NavigationService<UplateListingViewModel> uplateListingViewModel)
        {
            SubmitCommand = new CreateUplataCommand(this, studentService, uplataService, uplateListingViewModel);
            CancelCommand = new NavigateCommand<UplateListingViewModel>(uplateListingViewModel);
            SearchCommand = new KorisnikSearchCommand(this, studentService);
            _studenti = new ObservableCollection<StudentViewModel>();
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

    }
}
