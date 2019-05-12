using System.ComponentModel;
using Prism.Regions;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public interface IViewModel : INavigationAware, INotifyPropertyChanged
    {
    }
}