using System.Windows;
using System.Windows.Controls;

namespace WPFormation.Views.BoxMessage
{
    /// <summary>
    /// Interaction logic for BoxMessage.xaml
    /// </summary>
    public partial class BoxMessage : UserControl
    {
        public BoxMessage()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            /*MessageBox.Show("Could not open file.","ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            */

            MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tbinfo.Text = "Agreed";

            }
            else
            {
                tbinfo.Text = "Not Agreed";
            }
        }
    }
}
