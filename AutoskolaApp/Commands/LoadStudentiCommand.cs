using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.ListingViewModels;

namespace AutoskolaApp.Commands
{
    public class LoadStudentiCommand : AsyncCommandBase
    {
        private readonly StudentiListingViewModel _studentiListingViewModel;
        private readonly StudentService _studentService;

        public LoadStudentiCommand(StudentiListingViewModel studentiListingViewModel, StudentService studentService)
        {
            _studentiListingViewModel = studentiListingViewModel;
            _studentService = studentService;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _studentService.LoadStudenti();

                _studentiListingViewModel.UpdateReservations(_studentService.GetStudenti());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
