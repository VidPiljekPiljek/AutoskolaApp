using AutoskolaApp.Models;
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
    public class DeleteIspitCommand : AsyncCommandBase
    {
        private readonly IspitiListingViewModel _formViewModel;
        private readonly IspitService _ispitService;

        public DeleteIspitCommand(IspitiListingViewModel formViewModel, IspitService ispitService)
        {
            _formViewModel = formViewModel;
            _ispitService = ispitService;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _ispitService.DeleteIspit(_formViewModel.SelectedIspit.IDIspita);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
