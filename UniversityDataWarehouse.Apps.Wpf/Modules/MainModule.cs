using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using UniversityDataWarehouse.Apps.Wpf.ViewModels;
using UniversityDataWarehouse.Apps.Wpf.Views;

namespace UniversityDataWarehouse.Apps.Wpf.Modules
{
    // Modules are used by Prism to register views for navigation and region display.
    public class MainModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainView, MainViewModel>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {

        }
    }
}