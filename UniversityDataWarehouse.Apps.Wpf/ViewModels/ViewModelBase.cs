using Prism.Mvvm;
using Prism.Regions;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    //By ensuring our view models inherit from this base class, we ensure that
    //the Prism functionality needed for navigation and property/view binding is available.
    public abstract class ViewModelBase : BindableBase, IViewModel
    {
        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }
    }
}