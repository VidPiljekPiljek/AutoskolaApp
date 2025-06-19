using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels;
using AutoskolaApp.ViewModels.FormViewModels;
using AutoskolaApp.ViewModels.ListingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoskolaApp.Commands.SearchCommands
{
    public class KorisnikSearchCommand : AsyncCommandBase
    {
        private readonly UplateFormViewModel _formViewModel;
        private readonly StudentService _studentService;

        public KorisnikSearchCommand(UplateFormViewModel formViewModel, StudentService studentService)
        {
            _formViewModel = formViewModel;
            _studentService = studentService;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                IEnumerable<Student> studenti = await _studentService.StudentSearch(_formViewModel.ImeStudenta, _formViewModel.PrezimeStudenta);

                _formViewModel.StudentFound(studenti);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
