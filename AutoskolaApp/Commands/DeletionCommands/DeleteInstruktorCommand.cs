﻿using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.FormViewModels;
using AutoskolaApp.ViewModels.ListingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoskolaApp.Commands.DeletionCommands
{
    public class DeleteInstruktorCommand : AsyncCommandBase
    {
        private readonly InstruktoriListingViewModel _formViewModel;
        private readonly InstruktorService _instruktorService;
        private readonly KorisnikService _korisnikService;

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _korisnikService.DeleteKorisnik(_formViewModel.SelectedInstruktor.IDKorisnika);

                await _instruktorService.DeleteInstruktor(_formViewModel.SelectedInstruktor.IDInstruktora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
