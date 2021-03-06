using System;

namespace UniversityDataWarehouse.Models
{
    public class NavigationMenuItemModel
    {
        //Boilerplate used to generate hamburger menu entries
        public NavigationMenuItemModel(string title, string icon, string view)
        {
            Title = title;
            Icon = icon;
            View = view;
        }
        
        public string Title { get; set; }
        public string Icon { get; set; }
        public string View { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}