using System;
using System.Windows.Controls;
using Autofac;
using UniversityDataWarehouse.WPF.Pages;
using UniversityDataWarehouse.WPF.ViewModels;

namespace UniversityDataWarehouse.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        //Contains the internal frame
        public static Frame WindowFrame { get; private set; }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private MainPageViewModel ViewModel = App.Container.Resolve<MainPageViewModel>();

        protected override void OnInitialized(EventArgs e)
        {
            WindowFrame = ContentFrame;

            WindowFrame.Navigate(new Login());
            
            base.OnInitialized(e);
        }
    }
}