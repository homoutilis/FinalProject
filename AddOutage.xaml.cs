using System.Windows;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for AddOutage.xaml
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
                var newOutage = new Outage() { kLine = txtLine.Text, dtOutage = cldOutage.SelectedDate.ToString(), 
                    nReason = cmbReason.Text };
                newOutage.InsertOutage();
                txtLog.Text = newOutage.Except;
            }
            else
            {
                Close();
            }
        }
    }
}
