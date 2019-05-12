using Prism.Ioc;
using Prism.Modularity;
using UniversityDataWarehouse.Apps.Wpf.Views;
using UniversityDataWarehouse.Apps.WPF.ViewModels.FactCharts;

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