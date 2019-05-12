using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MahApps.Metro.Controls;
using Prism.Regions;
using UniversityDataWarehouse.Models;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private NavigationMenuItemModel _selectedItem;

        public MainViewModel(IRegionManager regionManager)
        {
            RegionManager = regionManager;

            MenuItems = new ObservableCollection<NavigationMenuItemModel>
            {
                new NavigationMenuItemModel("Home", "Home", "HomeView"),
                // Fact views
                new NavigationMenuItemModel("Assignments", "File", "AssignmentsView"),
                new NavigationMenuItemModel("Complaints", "EmoticonSadOutline", "ComplaintsView"),
                new NavigationMenuItemModel("Courses", "Golf", "CoursesView"),
                new NavigationMenuItemModel("Enrollments", "ClipboardAccountOutline", "EnrollmentsView"),
                new NavigationMenuItemModel("Genders", "GenderTransgender", "GendersView"),
                new NavigationMenuItemModel("Graduations", "School", "GraduationsView"),
                new NavigationMenuItemModel("Lecturers", "Teach", "LecturersView"),
                new NavigationMenuItemModel("Modules", "ViewModule", "ModulesView"),
                new NavigationMenuItemModel("Results", "CheckCircleOutline", "ResultsView"),
                new NavigationMenuItemModel("Students", "Earth", "StudentsView")
            };

            SelectedItem = MenuItems.First();
        }
        
        private IRegionManager RegionManager { get; }
        
        public ICollection<NavigationMenuItemModel> MenuItems { get; }
        
        public NavigationMenuItemModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (!SetProperty(ref _selectedItem, value)) return;

                RegionManager.RequestNavigate("MainRegion", _selectedItem.View);
            }
        }
    }
}