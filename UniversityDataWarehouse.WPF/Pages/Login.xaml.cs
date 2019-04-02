using System.Windows;
using System.Windows.Controls;
using Autofac;
using UniversityDataWarehouse.Data.Entities;
using UniversityDataWarehouse.WPF.ViewModels;

namespace UniversityDataWarehouse.WPF.Pages
{
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }
        
        //Inject ViewModel
        private LoginViewModel ViewModel = App.Container.Resolve<LoginViewModel>();

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            var user = new User();
            user.Username = UsernameTextBox.Text;
            user.Password = PasswordTextBox.Password;

            var loginSuccess = ViewModel.Login(user);

            if (loginSuccess)
            {
                MainWindow.WindowFrame.Navigate(new Main());
            }
        }
    }
}
