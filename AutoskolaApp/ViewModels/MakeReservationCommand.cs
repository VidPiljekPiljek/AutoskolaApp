using AutoskolaApp.Commands;
using AutoskolaApp.Services;
using AutoskolaApp.Stores;

namespace AutoskolaApp.ViewModels
{
    internal class MakeReservationCommand : AsyncCommandBase
    {
        private SignUpViewModel signUpViewModel;
        private KorisnikStore korisnikStore;
        private NavigationService<DashboardViewModel> dashboardNavigationService;

        public MakeReservationCommand(SignUpViewModel signUpViewModel, KorisnikStore korisnikStore, NavigationService<DashboardViewModel> dashboardNavigationService)
        {
            this.signUpViewModel = signUpViewModel;
            this.korisnikStore = korisnikStore;
            this.dashboardNavigationService = dashboardNavigationService;
        }
    }
}