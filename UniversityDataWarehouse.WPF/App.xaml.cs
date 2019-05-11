using System.Windows;
using Autofac;
using Prism.Ioc;
using Prism.Modularity;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Services;
using UniversityDataWarehouse.WPF.ViewModels;
using UniversityDataWarehouse.WPF.Views;

namespace UniversityDataWarehouse.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {

        protected override void OnStartup(StartupEventArgs e)
        {
        
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAuthService, AuthService>();
            containerRegistry.RegisterSingleton<ISeedService, SeedService>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<WPFModule>();
        }
    }
}