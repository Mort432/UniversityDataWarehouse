using System.Windows;
using Prism.Regions;
using UniversityDataWarehouse.Apps.Wpf.ViewModels;
using UniversityDataWarehouse.Data.Entities;

namespace UniversityDataWarehouse.Apps.Wpf.Views
{
    public partial class LoginView
    {
        public LoginView(IRegionManager regionManager)
        {
            RegionManager = regionManager;

            InitializeComponent();
        }

        private IRegionManager RegionManager { get; }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            var user = new User {Username = UsernameTextBox.Text, Password = PasswordTextBox.Password};

            var loginSuccess = ((LoginViewModel) DataContext).Login(user);

            if (loginSuccess) RegionManager.RequestNavigate("ContentRegion", "MainView");
        }
    }
}