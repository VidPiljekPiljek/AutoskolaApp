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
    public class CreateUplataCommand : AsyncCommandBase
    {
        private readonly UplateFormViewModel _formViewModel;
        private readonly StudentService _studentService;
        private readonly UplataService _uplataService;
        private readonly NavigationService<UplateListingViewModel> _uplateListingViewModelNavigationService;

        public CreateUplataCommand(UplateFormViewModel formViewModel, StudentService studentService, UplataService uplataService, NavigationService<UplateListingViewModel> uplateListingViewModelNavigationService)
        {
            _formViewModel = formViewModel;
            _studentService = studentService;
            _uplataService = uplataService;
            _uplateListingViewModelNavigationService = uplateListingViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override async Task ExecuteAsync(object? parameter)
        {


            try
            {
                Guid studentID = _formViewModel.SelectedStudent.IDStudenta;

                Uplata uplata = new Uplata(
                    _formViewModel.DatumUplate,
                    decimal.Parse(_formViewModel.Iznos),
                    _formViewModel.NacinUplate,
                    studentID
                    );

                await _uplataService.AddUplata(uplata);
                _uplateListingViewModelNavigationService.Navigate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
