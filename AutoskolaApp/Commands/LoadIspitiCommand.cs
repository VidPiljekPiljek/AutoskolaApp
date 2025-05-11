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
    public class LoadIspitiCommand : AsyncCommandBase
    {
        private readonly IspitiListingViewModel _ispitiListingViewModel;
        private readonly IspitService _ispitService;

        public LoadIspitiCommand(IspitiListingViewModel ispitiListingViewModel, IspitService ispitService)
        {
            _ispitiListingViewModel = ispitiListingViewModel;
            _ispitService = ispitService;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _ispitService.LoadInstruktori();

                _ispitiListingViewModel.UpdateReservations(_ispitService.GetInstruktori());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
