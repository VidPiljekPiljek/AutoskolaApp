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
    public class LoadUplateCommand : AsyncCommandBase
    {
        private readonly UplateListingViewModel _uplateListingViewModel;
        private readonly UplataStore _uplataStore;

        public LoadUplateCommand(UplateListingViewModel uplateListingViewModel, UplataStore uplataStore)
        {
            _uplateListingViewModel = uplateListingViewModel;
            _uplataStore = uplataStore;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                if (!_uplataStore.IsInitialized)
                {
                    await _uplataStore.Load();
                }

                _uplateListingViewModel.UpdateReservations(_uplataStore.Uplate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
