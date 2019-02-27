using System;
using System.Windows.Controls;
using Autofac;
using MahApps.Metro.Controls;
using UniversityDataWarehouse.Models;
using UniversityDataWarehouse.WPF.ViewModels;

namespace UniversityDataWarehouse.WPF.Pages
{
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }
        
        //Dependency injection
        private MainPageViewModel ViewModel = App.Container.Resolve<MainPageViewModel>();

        protected override void OnInitialized(EventArgs e)
        {
            DataContext = ViewModel;
            
            base.OnInitialized(e);
        }

        private void HamburgerMenu_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            //Get nav item
            var navItem = e.InvokedItem as NavigationMenuItemModel;

            if (navItem.Content == "Log Out")
            {
                ViewModel.Logout();
                
                //TODO: Redirect to login page
            }
            else
            {
                ContentFrame.Navigate(Activator.CreateInstance(navItem.ViewType));
            }
        }
    }
}
