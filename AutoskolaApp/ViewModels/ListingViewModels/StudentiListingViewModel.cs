using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Commands;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.FormViewModels;
using System.Windows.Input;
using AutoskolaApp.Commands.DeletionCommands;
using AutoskolaApp.Stores;

namespace AutoskolaApp.ViewModels.ListingViewModels
{
    public class StudentiListingViewModel : ViewModelBase, ILoadable
    {
        private readonly StudentService _studentService;
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

        public ICommand LoadStudentiCommand { get; }
        public ICommand CreateStudentCommand { get; }
        public ICommand NavigateBackCommand { get; }
        public ICommand DeleteSelectionCommand { get; }
        public bool IsLoaded { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public StudentiListingViewModel(StudentService studentService, StudentStore studentStore, KorisnikService korisnikService, NavigationService<StudentiFormViewModel> studentFormNavigationService, NavigationService<DashboardViewModel> dashboardNavigationService) // TO DO: ADD NAVIGATION SERVICE
        {
            _studentService = studentService;
            _studenti = new ObservableCollection<StudentViewModel>();

            LoadStudentiCommand = new LoadStudentiCommand(this, studentStore);
            CreateStudentCommand = new NavigateCommand<StudentiFormViewModel>(studentFormNavigationService);
            NavigateBackCommand = new NavigateCommand<DashboardViewModel>(dashboardNavigationService);
            DeleteSelectionCommand = new DeleteStudentCommand(this, korisnikService, studentService);
        }

        //public static InstruktoriListingViewModel LoadViewModel(InstruktorService instruktorService, NavigationService<KorisnikFormViewModel> korisnikFormNavigationService)
        //{
        //    InstruktoriListingViewModel instruktoriPageViewModel = new InstruktoriListingViewModel(instruktorService, korisnikFormNavigationService);

        //    instruktoriPageViewModel.LoadInstruktoriCommand.Execute(null);

        //    return instruktoriPageViewModel;
        //}

        public void UpdateStudenti(IEnumerable<Student> studenti)
        {
            _studenti.Clear();

            foreach (Student student in studenti)
            {
                StudentViewModel studentViewModel = new StudentViewModel(student);
                _studenti.Add(studentViewModel);
            }
        }

        public Task OnNavigatedToAsync()
        {
            throw new NotImplementedException();
        }

        public Task OnNavigatedFromAsync()
        {
            throw new NotImplementedException();
        }

        public void LoadViewModel()
        {
            LoadStudentiCommand.Execute(null);
        }
    }
}
