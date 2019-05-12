using Prism.Ioc;
using Prism.Modularity;
using UniversityDataWarehouse.Apps.Wpf.ViewModels;
using UniversityDataWarehouse.Apps.Wpf.Views;

namespace UniversityDataWarehouse.Apps.Wpf.Modules
{
    public class CourseModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CoursesView, CoursesViewModel>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {

        }
    }
}