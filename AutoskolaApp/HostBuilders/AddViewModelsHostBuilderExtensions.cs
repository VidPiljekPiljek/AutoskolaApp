using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using AutoskolaApp.Services;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels;
using AutoskolaApp.ViewModels.FormViewModels;
using AutoskolaApp.ViewModels.ListingViewModels;
using AutoskolaApp.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Wpf.Ui;

namespace AutoskolaApp.HostBuilders
{
    public static class AddViewModelsHostBuilderExtensions
    {
        public static IHostBuilder AddViewModels(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices(services =>
            {
                services.AddTransient<LoginViewModel>();
                services.AddSingleton<Func<LoginViewModel>>(s => () => s.GetRequiredService<LoginViewModel>());
                services.AddSingleton<NavigationService<LoginViewModel>>();

                services.AddTransient<DashboardViewModel>();
                services.AddSingleton<Func<DashboardViewModel>>(s => () => s.GetRequiredService<DashboardViewModel>());
                services.AddSingleton<NavigationService<DashboardViewModel>>();

                services.AddTransient<InstruktoriListingViewModel>();
                services.AddSingleton<Func<InstruktoriListingViewModel>>(s => () => s.GetRequiredService<InstruktoriListingViewModel>());
                services.AddSingleton<NavigationService<InstruktoriListingViewModel>>();
                services.AddTransient<StudentiListingViewModel>();
                services.AddSingleton<Func<StudentiListingViewModel>>(s => () => s.GetRequiredService<StudentiListingViewModel>());
                services.AddSingleton<NavigationService<StudentiListingViewModel>>();
                services.AddTransient<UplateListingViewModel>();
                services.AddSingleton<Func<UplateListingViewModel>>(s => () => s.GetRequiredService<UplateListingViewModel>());
                services.AddSingleton<NavigationService<UplateListingViewModel>>();
                services.AddTransient<VoznjeListingViewModel>();
                services.AddSingleton<Func<VoznjeListingViewModel>>(s => () => s.GetRequiredService<VoznjeListingViewModel>());
                services.AddSingleton<NavigationService<VoznjeListingViewModel>>();

                services.AddTransient<KorisnikFormViewModel>();
                services.AddSingleton<Func<KorisnikFormViewModel>>(s => () => s.GetRequiredService<KorisnikFormViewModel>());
                services.AddSingleton<NavigationService<KorisnikFormViewModel>>();
                services.AddTransient<InstruktoriFormViewModel>();
                services.AddSingleton<Func<InstruktoriFormViewModel>>(s => () => s.GetRequiredService<InstruktoriFormViewModel>());
                services.AddSingleton<NavigationService<InstruktoriFormViewModel>>();
                services.AddTransient<StudentiFormViewModel>();
                services.AddSingleton<Func<StudentiFormViewModel>>(s => () => s.GetRequiredService<StudentiFormViewModel>());
                services.AddSingleton<NavigationService<StudentiFormViewModel>>();
                services.AddTransient<UplateFormViewModel>();
                services.AddSingleton<Func<UplateFormViewModel>>(s => () => s.GetRequiredService<UplateFormViewModel>());
                services.AddSingleton<NavigationService<UplateFormViewModel>>();
                services.AddTransient<VoznjeFormViewModel>();
                services.AddSingleton<Func<VoznjeFormViewModel>>(s => () => s.GetRequiredService<VoznjeFormViewModel>());
                services.AddSingleton<NavigationService<VoznjeFormViewModel>>();

                services.AddSingleton<MainViewModel>();
            });

            return hostBuilder;
        }

        //private static LoginViewModel CreateLoginViewModel(IServiceProvider services)
        //{
        //    return LoginViewModel.LoadViewModel(
        //        services.GetRequiredService<KorisnikService>()
        //    );
        //}
    }
}
