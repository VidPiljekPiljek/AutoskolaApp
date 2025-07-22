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
    public class LoadInstruktoriCommand : AsyncCommandBase
    {
        private readonly InstruktoriListingViewModel _instruktoriListingViewModel;
        private readonly InstruktorStore _instruktorStore;

        public LoadInstruktoriCommand(InstruktoriListingViewModel instruktoriListingViewModel, InstruktorStore instruktorStore)
        {
            _instruktoriListingViewModel = instruktoriListingViewModel;
            _instruktorStore = instruktorStore;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                if (!_instruktorStore.IsInitialized)
                {
                    await _instruktorStore.Load();
                }

                _instruktoriListingViewModel.UpdateInstruktori(_instruktorStore.Instruktori);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
