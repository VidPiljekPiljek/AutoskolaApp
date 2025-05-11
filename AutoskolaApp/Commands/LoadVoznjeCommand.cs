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
    internal class LoadVoznjeCommand : AsyncCommandBase
    {
        private readonly VoznjeListingViewModel _voznjeListingViewModel;
        private readonly VoznjaService _voznjaService;

        public LoadVoznjeCommand(VoznjeListingViewModel voznjeListingViewModel, VoznjaService voznjaService)
        {
            _voznjeListingViewModel = voznjeListingViewModel;
            _voznjaService = voznjaService;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _voznjaService.LoadVoznje();

                _voznjeListingViewModel.UpdateReservations(_voznjaService.GetVoznje());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
