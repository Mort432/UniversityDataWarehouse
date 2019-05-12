using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using UniversityDataWarehouse.Apps.Wpf.Modules;
using UniversityDataWarehouse.Apps.Wpf.Views;
using UniversityDataWarehouse.Services;
using UniversityDataWarehouse.Services.FactServices;

namespace UniversityDataWarehouse.Apps.Wpf
{
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAuthService, AuthService>();
            containerRegistry.RegisterSingleton<ISeedService, SeedService>();
            
            //Dim handling
            containerRegistry.RegisterSingleton<IAssignmentFactService, AssignmentFactService>();
            containerRegistry.RegisterSingleton<IModuleDimService, ModuleDimService>();
            containerRegistry.RegisterSingleton<IComplaintFactService, ComplaintFactService>();
            containerRegistry.RegisterSingleton<ICourseDimService, CourseDimService>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<HomeModule>();
            moduleCatalog.AddModule<LoginModule>();
            moduleCatalog.AddModule<MainModule>();
            moduleCatalog.AddModule<AssignmentsModule>();
        }
    }
}