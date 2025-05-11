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
    public class LoadUplateCommand : AsyncCommandBase
    {
        private readonly UplateListingViewModel _uplateListingViewModel;
        private readonly UplataService _uplataService;

        public LoadUplateCommand(UplateListingViewModel uplateListingViewModel, UplataService uplataService)
        {
            _uplateListingViewModel = uplateListingViewModel;
            _uplataService = uplataService;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _uplataService.LoadUplate();

                _uplateListingViewModel.UpdateReservations(_uplataService.GetUplate());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
