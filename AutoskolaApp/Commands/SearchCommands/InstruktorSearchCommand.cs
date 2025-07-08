using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.FormViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoskolaApp.Commands.SearchCommands
{
    public class InstruktorSearchCommand : AsyncCommandBase
    {
        private readonly IspitiFormViewModel _formViewModel;
        private readonly InstruktorService _instruktorService;

        public InstruktorSearchCommand(IspitiFormViewModel formViewModel, InstruktorService instruktorService)
        {
            _formViewModel = formViewModel;
            _instruktorService = instruktorService;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                IEnumerable<Instruktor> instruktori = await _instruktorService.InstruktorSearch(_formViewModel.ImeInstruktora, _formViewModel.PrezimeInstruktora);

                _formViewModel.InstruktorFound(instruktori);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
