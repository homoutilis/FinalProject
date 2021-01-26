using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddOutage: Window
    {
        public AddOutage()
        {
            InitializeComponent();
        }

        private void WriteToDB(object sender, RoutedEventArgs e)
        {

            if (e.Source == btnOK)
            {
                Outage.kLine = txtLine.Text;
                Outage.dtOutage = cldOutage.SelectedDate.ToString();
                Outage.InsertOutage();
                txtLog.Text = Outage.Except;
            }
            else
            {
                Close();
            }
        }

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Outage.dtOutage = cldOutage.SelectedDate.ToString();


        }
    }
}
