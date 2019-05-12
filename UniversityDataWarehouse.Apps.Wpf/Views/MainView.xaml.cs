using System.Windows.Controls;
using Prism.Regions;

namespace UniversityDataWarehouse.Apps.Wpf.Views
{
    public partial class MainView
    {
        public MainView(IRegionManager regionManager)
        {
            RegionManager.SetRegionName(MainRegion, "MainRegion");
            RegionManager.SetRegionManager(MainRegion, regionManager);
        }
    }
}
