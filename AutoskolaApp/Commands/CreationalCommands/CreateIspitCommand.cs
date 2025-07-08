using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.FormViewModels;
using AutoskolaApp.ViewModels.ListingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoskolaApp.Commands.CreationalCommands
{
    public class CreateIspitCommand : AsyncCommandBase
    {
        private readonly IspitiFormViewModel _formViewModel;
        private readonly IspitService _ispitService;
        private readonly NavigationService<IspitiListingViewModel> _ispitiListingViewModelNavigationService;

        public CreateIspitCommand(IspitiFormViewModel formViewModel, IspitService ispitService, NavigationService<IspitiListingViewModel> ispitiListingViewModelNavigationService)
        {
            _formViewModel = formViewModel;
            _ispitService = ispitService;
            _ispitiListingViewModelNavigationService = ispitiListingViewModelNavigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                Ispit ispit = new Ispit(
                    _formViewModel.DateTime,
                    _formViewModel.VrstaIspita,
                    _formViewModel.SelectedInstruktor.IDInstruktora
                );

                await _ispitService.AddIspit(ispit);
                _ispitiListingViewModelNavigationService.Navigate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
