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
    public class DeleteUplateCommand : AsyncCommandBase
    {
        private readonly UplateListingViewModel _formViewModel;
        private readonly UplataService _uplataService;

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _uplataService.DeleteUplata(_formViewModel.SelectedUplata.IDUplate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
