using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using UniversityDataWarehouse.Apps.Wpf.Modules;
using UniversityDataWarehouse.Apps.Wpf.Views;
using UniversityDataWarehouse.Services;

namespace UniversityDataWarehouse.Apps.Wpf
{
    public partial class App
    {
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
            moduleCatalog.AddModule<HomeModule>();
            moduleCatalog.AddModule<LoginModule>();
        }
    }
}