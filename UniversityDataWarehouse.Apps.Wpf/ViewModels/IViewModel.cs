using System.ComponentModel;
using Prism.Regions;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public interface IViewModel : INavigationAware, INotifyPropertyChanged
    {
        //This essentially only exists to ensure all view models inherit from Prism base classes.
    }
}