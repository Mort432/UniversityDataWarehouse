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
    }
}