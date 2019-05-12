using Prism.Ioc;
using Prism.Modularity;
using UniversityDataWarehouse.Apps.Wpf.ViewModels;
using UniversityDataWarehouse.Apps.Wpf.Views;

namespace UniversityDataWarehouse.Apps.Wpf.Modules
{
    public class GraduationsModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<GraduationsView, GraduationsViewModel>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {

        }
    }
}