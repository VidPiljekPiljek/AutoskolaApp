using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoskolaApp.Services;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels;

namespace AutoskolaApp.Commands
{
    public class LoadKorisniciCommand : AsyncCommandBase
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly KorisnikService _korisnikService;

        public LoadKorisniciCommand(LoginViewModel loginViewModel, KorisnikService korisnikService)
        {
            _loginViewModel = loginViewModel;
            _korisnikService = korisnikService;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            _loginViewModel.IsLoading = true;

            try
            {
                await _korisnikService.LoadAllKorisniciAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _loginViewModel.IsLoading = false;
            }
        }
    }
}
