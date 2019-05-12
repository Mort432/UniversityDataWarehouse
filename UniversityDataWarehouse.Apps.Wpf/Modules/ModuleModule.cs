using Prism.Ioc;
using Prism.Modularity;
using UniversityDataWarehouse.Apps.Wpf.ViewModels;
using UniversityDataWarehouse.Apps.Wpf.Views;

namespace UniversityDataWarehouse.Apps.Wpf.Modules
{
    public class ModuleModule : IModule //Yes, I know, the name is dumb. Sue me.
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ModulesView, ModulesViewModel>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {

        }
    }
}