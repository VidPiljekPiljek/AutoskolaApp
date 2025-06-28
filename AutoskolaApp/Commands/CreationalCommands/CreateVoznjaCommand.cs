using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.FormViewModels;
using AutoskolaApp.ViewModels.ListingViewModels;
using System.Windows;
using AutoskolaApp.ViewModels;

namespace AutoskolaApp.Commands.CreationalCommands
{
    public class CreateVoznjaCommand : AsyncCommandBase
    {
        private readonly VoznjeFormViewModel _formViewModel;
        private readonly StudentService _studentService;
        private readonly InstruktorService _instruktorService;
        private readonly VoznjaService _voznjaService;
        private readonly NavigationService<VoznjeListingViewModel> _voznjeListingViewModelNavigationService;

        public CreateVoznjaCommand(VoznjeFormViewModel formViewModel, StudentService studentService, InstruktorService instruktorService, VoznjaService voznjaService, NavigationService<VoznjeListingViewModel> voznjeListingViewModelNavigationService)
        {
            _formViewModel = formViewModel;
            _studentService = studentService;
            _instruktorService = instruktorService;
            _voznjaService = voznjaService;
            _voznjeListingViewModelNavigationService = voznjeListingViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                int studentID = await _studentService.GetStudentID(_formViewModel.StudentIme, _formViewModel.StudentPrezime);
                int instruktorID = await _instruktorService.GetInstruktorID(_formViewModel.StudentIme, _formViewModel.StudentPrezime);

                Voznja voznja = new Voznja(
                    _formViewModel.DatumVoznje,
                    studentID,
                    instruktorID
                    );

                await _voznjaService.AddVoznja(voznja);
                _voznjeListingViewModelNavigationService.Navigate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
