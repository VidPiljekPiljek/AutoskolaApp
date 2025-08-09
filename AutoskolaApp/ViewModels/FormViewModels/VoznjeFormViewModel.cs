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
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoskolaApp.ViewModels.FormViewModels
{
    public class VoznjeFormViewModel : ViewModelBase, ILoadable
    {
        private readonly ObservableCollection<StudentViewModel> _studenti;
        public IEnumerable<StudentViewModel> Studenti => _studenti;
        private readonly ObservableCollection<InstruktorViewModel> _instruktori;
        public IEnumerable<InstruktorViewModel> Instruktori => _instruktori;
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

        private DateTime _datumVoznje = DateTime.Now;
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
        public AsyncCommandBase SearchCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public VoznjeFormViewModel(StudentService studentService, InstruktorService instruktorService, VoznjaService voznjaService, NavigationService<VoznjeListingViewModel> voznjeNavigationService) {
            SubmitCommand = new CreateVoznjaCommand(this, studentService, instruktorService, voznjaService, voznjeNavigationService);
            CancelCommand = new NavigateCommand<VoznjeListingViewModel>(voznjeNavigationService, null);
            SearchCommand = new InstruktorStudentSearchCommand(this, studentService, instruktorService);

            _instruktori = new ObservableCollection<InstruktorViewModel>();
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

        public void InstruktorFound(IEnumerable<Instruktor> instruktori)
        {
            _instruktori.Clear();

            foreach (Instruktor instruktor in instruktori)
            {
                InstruktorViewModel instruktorViewModel = new InstruktorViewModel(instruktor);
                _instruktori.Add(instruktorViewModel);
            }
        }

        public void LoadViewModel(object parameter)
        {
            if (parameter != null)
            {
                VoznjaViewModel voznja = (VoznjaViewModel)parameter;
                DatumVoznje = voznja.DatumVoznje;
            }
        }
    }
}
