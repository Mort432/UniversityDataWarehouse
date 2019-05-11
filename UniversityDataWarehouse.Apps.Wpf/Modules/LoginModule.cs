using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using UniversityDataWarehouse.Apps.Wpf.Views;

namespace UniversityDataWarehouse.Apps.Wpf.Modules
{
    public class LoginModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(LoginView));
        }
    }
}