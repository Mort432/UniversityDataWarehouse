using System.Collections.Generic;
using UniversityDataWarehouse.Models;
using UniversityDataWarehouse.Services;
using UniversityDataWarehouse.WPF.Views;

namespace UniversityDataWarehouse.WPF.ViewModels
{
    public class MainPageViewModel
    {
        //public IEnumerable<NavigationMenuItemModel> MenuItems => GetMenuItems();
        
        //Dependency injection
        private IAuthService _authService;

        public MainPageViewModel(IAuthService authService)
        {
            _authService = authService;
        }

        //public IEnumerable<NavigationMenuItemModel> GetMenuItems()
        //{
        //    var menuItems = new List<NavigationMenuItemModel>();

        //    menuItems.Add(new NavigationMenuItemModel()
        //    {
        //        Content = "Home",
        //        Glyph = char.ConvertFromUtf32(0xE80F).ToString(),
        //        ViewType = typeof(Home)
        //    });

        //    return menuItems;
        //}

        public void Logout()
        {
            _authService.Logout();
        }
    }
}