using System.Windows;

namespace FinalProject
{
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
                if (!Check())
                    return;
                var newOutage = new Outage()
                {
                    kLine = txtLine.Text, dtOutage = cldOutage.SelectedDate.ToString(),
                    nReason = cmbReason.Text
                };
                newOutage.InsertOutage();
                txtLog.Text = newOutage.Except;
            }
            else
            {
                Close();
            }
        }

        private bool Check()
        {
            if (cmbReason.Text == "")
            {
                txtLog.Text = "Выберите причину отключения!";
                return false;
            }
            else if (txtLine.Text == "")
            {
                txtLog.Text = "Введите номер линии!";
                return false;
            }
            else
                return true;
        }
    }
}
