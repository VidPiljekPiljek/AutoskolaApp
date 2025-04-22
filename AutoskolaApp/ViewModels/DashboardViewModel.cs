using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutoskolaApp.Models;
using AutoskolaApp.Stores;
using Wpf.Ui.Abstractions.Controls;
using Wpf.Ui.Controls;
using Wpf.Ui.Input;

namespace AutoskolaApp.ViewModels
{
    public class DashboardViewModel : ViewModelBase, INavigationAware
    {
        private readonly KorisnikStore _korisnikStore;
        public KorisnikStore KorisnikStore => _korisnikStore;

        public int IDUloge { get; set; }
        public ObservableCollection<NavigationViewItem> NavigationItems { get; set; }
        //public ObservableCollection<NavigationViewItem> AdminNavigationItems { get; set; } = new ObservableCollection<NavigationViewItem>() {
        //    new NavigationViewItem() { Name = "Instruktori", Icon = new SymbolIcon(SymbolRegular.Home24), TargetPageType = typeof(Views.Pages.Administrator.InstruktoriPage) },
        //    new NavigationViewItem() { Name = "Studenti", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Administrator.StudentiPage) },
        //    new NavigationViewItem() { Name = "Ispiti", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Administrator.IspitiPage) },
        //    new NavigationViewItem() { Name = "Uplate", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Administrator.UplatePage) },
        //    new NavigationViewItem() { Name = "Voznje", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Administrator.VoznjePage) }
        //};
        //public ObservableCollection<NavigationViewItem> InstruktorNavigationItems { get; set; } = new ObservableCollection<NavigationViewItem>()
        //    {
        //        new NavigationViewItem() { Name = "Ispiti", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Instruktor.IspitiPage) },
        //        new NavigationViewItem() { Name = "Voznje", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Instruktor.VoznjePage) }
        //    };
        //public ObservableCollection<NavigationViewItem> StudentNavigationItems { get; set; } = new ObservableCollection<NavigationViewItem>()
        //    {
        //        new NavigationViewItem() { Name = "Ispiti", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Student.IspitiPage) },
        //        new NavigationViewItem() { Name = "Voznje", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Student.VoznjePage) },
        //        new NavigationViewItem() { Name = "Uplate", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Student.UplatePage) }
        //    };

        public DashboardViewModel(KorisnikStore korisnikStore)
        {
            _korisnikStore = korisnikStore;
        }

        public Task OnNavigatedToAsync()
        {
            Type uloga = _korisnikStore.KorisnikAuthorization();
            if (uloga == typeof(Administrator))
            {
                NavigationItems = new ObservableCollection<NavigationViewItem>() {
                    new NavigationViewItem() { Name = "Instruktori", Icon = new SymbolIcon(SymbolRegular.Home24), TargetPageType = typeof(Views.Pages.Administrator.InstruktoriPage) },
                    new NavigationViewItem() { Name = "Studenti", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Administrator.StudentiPage) },
                    new NavigationViewItem() { Name = "Ispiti", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Administrator.IspitiPage) },
                    new NavigationViewItem() { Name = "Uplate", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Administrator.UplatePage) },
                    new NavigationViewItem() { Name = "Voznje", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Administrator.VoznjePage) }
                };
            }
            else if (uloga == typeof(Instruktor))
            {
                NavigationItems = new ObservableCollection<NavigationViewItem>()
                {
                    new NavigationViewItem() { Name = "Ispiti", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Instruktor.IspitiPage) },
                    new NavigationViewItem() { Name = "Voznje", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Instruktor.VoznjePage) }
                };
            }
            else if (uloga == typeof(Student))
            {
                NavigationItems = new ObservableCollection<NavigationViewItem>()
                {
                    new NavigationViewItem() { Name = "Ispiti", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Student.IspitiPage) },
                    new NavigationViewItem() { Name = "Voznje", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Student.VoznjePage) },
                    new NavigationViewItem() { Name = "Uplate", Icon = new SymbolIcon(SymbolRegular.Home24) , TargetPageType = typeof(Views.Pages.Student.UplatePage) }
                };
            }
            return Task.CompletedTask;
        }

        public Task OnNavigatedFromAsync()
        {
            throw new NotImplementedException();
        }
    }
}
