using Prism.Ioc;
using Prism.Modularity;
using UniversityDataWarehouse.Apps.Wpf.ViewModels;
using UniversityDataWarehouse.Apps.Wpf.Views;

namespace UniversityDataWarehouse.Apps.Wpf.Modules
{
    public class AssignmentsModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<AssignmentsView, AssignmentsViewModel>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {

        }
    }
}