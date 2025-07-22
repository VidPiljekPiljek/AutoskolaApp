using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoskolaApp.Services;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels.ListingViewModels;

namespace AutoskolaApp.Commands
{
    internal class LoadVoznjeCommand : AsyncCommandBase
    {
        private readonly VoznjeListingViewModel _voznjeListingViewModel;
        private readonly VoznjaStore _voznjaStore;

        public LoadVoznjeCommand(VoznjeListingViewModel voznjeListingViewModel, VoznjaStore voznjaStore)
        {
            _voznjeListingViewModel = voznjeListingViewModel;
            _voznjaStore = voznjaStore;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                if (!_voznjaStore.IsInitialized)
                {
                    await _voznjaStore.Load();
                }

                _voznjeListingViewModel.UpdateReservations(_voznjaStore.Voznje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
