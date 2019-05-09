using System.Windows;
using Autofac;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Services;
using UniversityDataWarehouse.WPF.ViewModels;

namespace UniversityDataWarehouse.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static IContainer Container { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            BuildContainer();
        }

        private void BuildContainer()
        {
            var builder = new ContainerBuilder();
            
            //Services
            builder.RegisterType<AuthService>().As<IAuthService>().SingleInstance();
            builder.RegisterType<SeedService>().As<ISeedService>().SingleInstance();

            //View models
            builder.RegisterType<MainPageViewModel>().InstancePerDependency();
            builder.RegisterType<LoginViewModel>().InstancePerDependency();

            Container = builder.Build();
        }
    }
}