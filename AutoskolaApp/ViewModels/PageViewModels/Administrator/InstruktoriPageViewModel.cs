using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AutoskolaApp.Commands;
using AutoskolaApp.Models;
using AutoskolaApp.Services;
using Wpf.Ui.Abstractions.Controls;

namespace AutoskolaApp.ViewModels.PageViewModels.Administrator
{
    public class InstruktoriPageViewModel : ViewModelBase, INavigationAware
    {
        private readonly InstruktorService _instruktorService;
        private readonly ObservableCollection<InstruktorViewModel> _instruktori;
        public IEnumerable<InstruktorViewModel> Instruktori => _instruktori;

        public ICommand LoadInstruktoriCommand { get; }
        public ICommand CreateInstruktorCommand { get; }

        public InstruktoriPageViewModel(InstruktorService instruktorService) // TO DO: ADD NAVIGATION SERVICE
        {
            _instruktorService = instruktorService;
            _instruktori = new ObservableCollection<InstruktorViewModel>();

            LoadInstruktoriCommand = new LoadInstruktoriCommand(this, _instruktorService);
        }

        public static InstruktoriPageViewModel LoadViewModel(InstruktorService instruktorService)
        {
            InstruktoriPageViewModel instruktoriPageViewModel = new InstruktoriPageViewModel(instruktorService);

            instruktoriPageViewModel.LoadInstruktoriCommand.Execute(null);

            return instruktoriPageViewModel;
        }

        public void UpdateReservations(IEnumerable<Instruktor> instruktori)
        {
            _instruktori.Clear();

            foreach (Instruktor instruktor in instruktori)
            {
                InstruktorViewModel instruktorViewModel = new InstruktorViewModel(instruktor);
                _instruktori.Add(instruktorViewModel);
            }
        }

        public Task OnNavigatedToAsync()
        {
            throw new NotImplementedException();
        }

        public Task OnNavigatedFromAsync()
        {
            throw new NotImplementedException();
        }
    }
}
