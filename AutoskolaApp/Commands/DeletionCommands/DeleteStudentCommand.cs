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
        private readonly StudentiListingViewModel _formViewModel;
        private readonly KorisnikService _korisnikService;
        private readonly StudentService _studentService;

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _korisnikService.DeleteKorisnik(_formViewModel.SelectedStudent.IDKorisnika);

                await _studentService.DeleteStudent(_formViewModel.SelectedStudent.IDStudenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
