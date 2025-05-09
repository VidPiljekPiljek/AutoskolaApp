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
using AutoskolaApp.ViewModels.PageViewModels.Administrator;
using AutoskolaApp.Views;
using AutoskolaApp.Views.Pages.Administrator;
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

                services.AddSingleton<InstruktoriPage>();
                services.AddSingleton<Func<InstruktoriPageViewModel>>(s => () => s.GetRequiredService<InstruktoriPageViewModel>());
                services.AddSingleton<PageNavigationService<InstruktoriPageViewModel>>();

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
