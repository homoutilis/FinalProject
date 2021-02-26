using System;
using System.Windows;


namespace FinalProject
{
    public partial class MainWindow: Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataBase.SetConnection();
        }

        private void AddOutage(object sender, RoutedEventArgs e)
        {
            var window = new AddOutage();
            window.Show();
        }

        private void AddAppToDB(object sender, RoutedEventArgs e)
        {
            VarBinary.AddAppToDB();
        }
    }
}
