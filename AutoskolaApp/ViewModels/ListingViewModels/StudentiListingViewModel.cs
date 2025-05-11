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

namespace AutoskolaApp.ViewModels.ListingViewModels
{
    public class StudentiListingViewModel : ViewModelBase, ILoadable
    {
        private readonly StudentService _studentService;
        private readonly ObservableCollection<StudentViewModel> _studenti;
        public IEnumerable<StudentViewModel> Studenti => _studenti;

        public ICommand LoadStudentiCommand { get; }
        public ICommand CreateStudentCommand { get; }

        public StudentiListingViewModel(StudentService studentService, NavigationService<StudentiFormViewModel> studentFormNavigationService) // TO DO: ADD NAVIGATION SERVICE
        {
            _studentService = studentService;
            _studenti = new ObservableCollection<StudentViewModel>();

            LoadStudentiCommand = new LoadStudentiCommand(this, studentService);
            CreateStudentCommand = new NavigateCommand<StudentiFormViewModel>(studentFormNavigationService);
        }

        //public static InstruktoriListingViewModel LoadViewModel(InstruktorService instruktorService, NavigationService<KorisnikFormViewModel> korisnikFormNavigationService)
        //{
        //    InstruktoriListingViewModel instruktoriPageViewModel = new InstruktoriListingViewModel(instruktorService, korisnikFormNavigationService);

        //    instruktoriPageViewModel.LoadInstruktoriCommand.Execute(null);

        //    return instruktoriPageViewModel;
        //}

        public void UpdateReservations(IEnumerable<Student> studenti)
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
