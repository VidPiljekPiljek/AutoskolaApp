using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.PageViewModels.Administrator;

namespace AutoskolaApp.Commands
{
    public class LoadInstruktoriCommand : AsyncCommandBase
    {
        private readonly InstruktoriPageViewModel _instruktoriPageViewModel;
        private readonly InstruktorService _instruktorService;

        public LoadInstruktoriCommand(InstruktoriPageViewModel instruktoriPageViewModel, InstruktorService instruktorService)
        {
            _instruktoriPageViewModel = instruktoriPageViewModel;
            _instruktorService = instruktorService;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _instruktorService.LoadInstruktori();

                _instruktoriPageViewModel.UpdateReservations(_instruktorService.GetInstruktori());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
