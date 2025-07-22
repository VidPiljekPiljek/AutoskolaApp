using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.ListingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoskolaApp.Commands.DeletionCommands
{
    public class DeleteVoznjaCommand : AsyncCommandBase
    {
        private readonly VoznjeListingViewModel _formViewModel;
        private readonly VoznjaService _voznjaService;

        public DeleteVoznjaCommand(VoznjeListingViewModel formViewModel, VoznjaService voznjaService)
        {
            _formViewModel = formViewModel;
            _voznjaService = voznjaService;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _voznjaService.DeleteVoznja(_formViewModel.SelectedVoznja.IDVoznje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
