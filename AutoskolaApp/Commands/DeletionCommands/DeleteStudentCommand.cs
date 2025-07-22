using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.ListingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoskolaApp.Commands.DeletionCommands
{
    public class DeleteStudentCommand : AsyncCommandBase
    {
        private readonly StudentiListingViewModel _listingViewModel;
        private readonly KorisnikService _korisnikService;
        private readonly StudentService _studentService;

        public DeleteStudentCommand(StudentiListingViewModel listingViewModel, KorisnikService korisnikService, StudentService studentService)
        {
            _listingViewModel = listingViewModel;
            _korisnikService = korisnikService;
            _studentService = studentService;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _korisnikService.DeleteKorisnik(_listingViewModel.SelectedStudent.IDKorisnika);

                await _studentService.DeleteStudent(_listingViewModel.SelectedStudent.IDStudenta);

                _listingViewModel.LoadStudentiCommand.Execute(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
