using System;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using UniversityDataWarehouse.WPF.Pages;

namespace UniversityDataWarehouse.WPF
{
    public class WPFModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Login));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}