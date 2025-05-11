using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.FormViewModels;
using AutoskolaApp.ViewModels.ListingViewModels;

namespace AutoskolaApp.Commands.CreationalCommands
{
    public class CreateStudentCommand : AsyncCommandBase
    {
        private readonly StudentiFormViewModel _formViewModel;
        private readonly KorisnikService _korisnikService;
        private readonly StudentService _studentService;
        private readonly NavigationService<StudentiListingViewModel> _studentiListingViewModelNavigationService;

        public CreateStudentCommand(StudentiFormViewModel formViewModel, KorisnikService korisnikService, StudentService studentService, NavigationService<StudentiListingViewModel> studentiListingViewModelNavigationService)
        {
            _formViewModel = formViewModel;
            _korisnikService = korisnikService;
            _studentService = studentService;
            _studentiListingViewModelNavigationService = studentiListingViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override async Task ExecuteAsync(object? parameter)
        {


            try
            {
                Korisnik korisnik = new Korisnik(
                    _formViewModel.KorisnickoIme,
                    _formViewModel.Lozinka,
                    2
                );





                await _korisnikService.AddKorisnik(korisnik);

                Guid korisnikID = await _korisnikService.GetKorisnikID(korisnik.KorisnickoIme, korisnik.Lozinka);

                Student student = new Student(
                    _formViewModel.OIB,
                    _formViewModel.Ime,
                    _formViewModel.Prezime,
                    _formViewModel.DatumRodjenja,
                    _formViewModel.DatumPocetka,
                    0,
                    korisnikID
                    );

                await _studentService.AddStudent(student);
                _studentiListingViewModelNavigationService.Navigate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
