using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Commands;
using System.Windows.Input;
using AutoskolaApp.Commands.CreationalCommands;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.ListingViewModels;
using AutoskolaApp.Commands.EditCommands;
using AutoskolaApp.Models;

namespace AutoskolaApp.ViewModels.FormViewModels
{
    public class StudentiFormViewModel : ViewModelBase, ILoadable
    {
        private Student _student;
        public Student Student
        {
            get { return _student; }
            set
            {
                _student = value;
                OnPropertyChanged(nameof(Student));
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
                _student.OIB = value;
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
                _student.Ime = value;
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
                _student.Prezime = value;
            }
        }

        private DateTime _datumRodjenja = DateTime.Now;
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set
            {
                _datumRodjenja = value;
                OnPropertyChanged(nameof(DatumRodjenja));
                _student.DatumRodjenja = value;
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
                _student.DatumPocetka = value;
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

        public StudentiFormViewModel(KorisnikService korisnikService, StudentService studentService, NavigationService<StudentiListingViewModel> studentiListingViewModel)
        {
            SubmitCommand = new CreateStudentCommand(this, korisnikService, studentService, studentiListingViewModel);
            EditCommand = new EditStudentCommand(this, studentService, studentiListingViewModel);
            _student = new Student();
            _isEditMode = false;
            CancelCommand = new NavigateCommand<StudentiListingViewModel>(studentiListingViewModel, null);
        }

        public void LoadViewModel(object parameter)
        {
            if (parameter != null)
            {
                StudentViewModel student = (StudentViewModel)parameter;
                OIB = student.OIB;
                Ime = student.Ime;
                Prezime = student.Prezime;
                DatumPocetka = DateTime.Parse(student.DatumPocetka);
                DatumRodjenja = DateTime.Parse(student.DatumRodjenja);
                _student.IDStudenta = student.IDStudenta;
                _student.OIB = student.OIB;
                _student.Ime = student.Ime;
                _student.Prezime = student.Prezime;
                _student.DatumPocetka = DateTime.Parse(student.DatumPocetka);
                _student.DatumRodjenja = DateTime.Parse(student.DatumRodjenja);
                _student.IDKorisnika = student.IDKorisnika;
                _isEditMode = true;
            }
            else
            {
                _isEditMode = false;
            }
        }
    }
}
