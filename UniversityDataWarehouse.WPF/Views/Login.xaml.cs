using System.Windows;
using System.Windows.Controls;
using Autofac;
using UniversityDataWarehouse.Data.Entities;
using UniversityDataWarehouse.WPF.ViewModels;

namespace UniversityDataWarehouse.WPF.Views
{
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }
       

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            var user = new User();
            user.Username = UsernameTextBox.Text;
            user.Password = PasswordTextBox.Password;

            var loginSuccess = ((LoginViewModel)DataContext).Login(user);

            if (loginSuccess)
            {
                //MainWindow.WindowFrame.Navigate(new Main());
            }
        }
    }
}
