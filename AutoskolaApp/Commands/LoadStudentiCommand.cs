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
    public class LoadStudentiCommand : AsyncCommandBase
    {
        private readonly StudentiListingViewModel _studentiListingViewModel;
        private readonly StudentStore _studentStore;

        public LoadStudentiCommand(StudentiListingViewModel studentiListingViewModel, StudentStore studentStore)
        {
            _studentiListingViewModel = studentiListingViewModel;
            _studentStore = studentStore;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                if (!_studentStore.IsInitialized)
                {
                    await _studentStore.Load();
                }

                _studentiListingViewModel.UpdateStudenti(_studentStore.Studenti);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
