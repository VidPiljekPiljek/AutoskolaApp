using AutoskolaApp.Services;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels.ListingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoskolaApp.Commands
{
    public class LoadIspitiCommand : AsyncCommandBase
    {
        private readonly IspitiListingViewModel _ispitiListingViewModel;
        private readonly IspitStore _ispitStore;

        public LoadIspitiCommand(IspitiListingViewModel ispitiListingViewModel, IspitStore ispitStore)
        {
            _ispitiListingViewModel = ispitiListingViewModel;
            _ispitStore = ispitStore;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                if (!_ispitStore.IsInitialized)
                {
                    await _ispitStore.Load();
                }

                _ispitiListingViewModel.UpdateReservations(_ispitStore.Ispiti);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
