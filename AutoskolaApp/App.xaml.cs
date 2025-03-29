using System.Configuration;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Wpf.Ui;
using AutoskolaApp.Services;
using AutoskolaApp.Services.KorisnikProviders;
using AutoskolaApp.Services.KorisnikCreators;
using AutoskolaApp.Models;
using AutoskolaApp.Stores;
using AutoskolaApp.DbContexts;
using AutoskolaApp.ViewModels;

namespace AutoskolaApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    // The.NET Generic Host provides dependency injection, configuration, logging, and other services.
    // https://docs.microsoft.com/dotnet/core/extensions/generic-host
    // https://docs.microsoft.com/dotnet/core/extensions/dependency-injection
    // https://docs.microsoft.com/dotnet/core/extensions/configuration
    // https://docs.microsoft.com/dotnet/core/extensions/logging
    private static readonly IHost _host = Host
        .CreateDefaultBuilder()
        .ConfigureAppConfiguration(c => { c.SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)); })
        .ConfigureServices((context, services) =>
        {
            services.AddSingleton<MainWindow>(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            services.AddSingleton<IAutoskolaDbContextFactory>(new InMemoryAutoskolaDbContextFactory());

            services.AddSingleton<IKorisnikProvider, DatabaseKorisnikProvider>();
            services.AddSingleton<IKorisnikCreator, DatabaseKorisnikCreator>();

            services.AddTransient<KorisnikManager>();

            services.AddSingleton<NavigationStore>();
            services.AddSingleton<KorisnikStore>();

        }).Build();

    /// <summary>
    /// Gets registered service.
    /// </summary>
    /// <typeparam name="T">Type of the service to get.</typeparam>
    /// <returns>Instance of the service or <see langword="null"/>.</returns>
    public static T GetService<T>()
        where T : class
    {
        return _host.Services.GetService(typeof(T)) as T;
    }

    /// <summary>
    /// Occurs when the application is loading.
    /// </summary>
    private void OnStartup(object sender, StartupEventArgs e)
    {
        _host.Start();
        //DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=toDoListApp.db").Options;
        //WPFUI_ToDoListDBContext dbContext = new WPFUI_ToDoListDBContext(options);

        //dbContext.Database.Migrate();
    }

    /// <summary>
    /// Occurs when the application is closing.
    /// </summary>
    private async void OnExit(object sender, ExitEventArgs e)
    {
        await _host.StopAsync();

        _host.Dispose();
    }

    /// <summary>
    /// Occurs when an exception is thrown by an application but not handled.
    /// </summary>
    private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        // For more info see https://docs.microsoft.com/en-us/dotnet/api/system.windows.application.dispatcherunhandledexception?view=windowsdesktop-6.0
    }
}

