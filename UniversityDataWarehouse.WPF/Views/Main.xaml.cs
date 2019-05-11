using System;
using System.Windows.Controls;
using Autofac;
using MahApps.Metro.Controls;
using UniversityDataWarehouse.Models;
using UniversityDataWarehouse.WPF.ViewModels;

namespace UniversityDataWarehouse.WPF.Views
{
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }
        
        private void HamburgerMenu_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            //Get nav item
            var navItem = e.InvokedItem as NavigationMenuItemModel;

            if (navItem.Content == "Log Out")
            {
                ((MainPageViewModel)DataContext).Logout();

                //MainWindow.WindowFrame.Navigate(new Login());
            }
            else
            {
                ContentFrame.Navigate(Activator.CreateInstance(navItem.ViewType));
            }
        }
    }
}
