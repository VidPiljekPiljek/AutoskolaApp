using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.FormViewModels;
using AutoskolaApp.ViewModels.ListingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoskolaApp.Commands.EditCommands
{
    public class EditStudentCommand : AsyncCommandBase
    {
        private readonly StudentiFormViewModel _formViewModel;
        private readonly StudentService _studentService;
        private readonly NavigationService<StudentiListingViewModel> _studentiListingViewModelNavigationService;

        public EditStudentCommand(StudentiFormViewModel formViewModel, StudentService studentService, NavigationService<StudentiListingViewModel> studentiListingViewModelNavigationService)
        {
            _formViewModel = formViewModel;
            _studentService = studentService;
            _studentiListingViewModelNavigationService = studentiListingViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return _formViewModel.IsEditMode;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                _studentService.EditStudent(_formViewModel.Student);

                _studentiListingViewModelNavigationService.Navigate(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
