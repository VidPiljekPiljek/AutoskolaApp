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
    public class LoadInstruktoriCommand : AsyncCommandBase
    {
        private readonly InstruktoriListingViewModel _instruktoriListingViewModel;
        private readonly InstruktorService _instruktorService;

        public LoadInstruktoriCommand(InstruktoriListingViewModel instruktoriListingViewModel, InstruktorService instruktorService)
        {
            _instruktoriListingViewModel = instruktoriListingViewModel;
            _instruktorService = instruktorService;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _instruktorService.LoadInstruktori();

                _instruktoriListingViewModel.UpdateReservations(_instruktorService.GetInstruktori());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
