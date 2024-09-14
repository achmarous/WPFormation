using System.Windows.Controls;
using System.Windows;

namespace WPFormation.Views.Forms
{
    /// <summary>
    /// Interaction logic for ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder 
        { 
            get {  return placeholder; }
            set 
            {  
                placeholder = value; 

                //do not do this
                tbPlaceHolder.Text = placeholder;
                // The better way is to use OnPropertyChanged
            }
        }

        private void btnClear_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
                tbPlaceHolder.Visibility = Visibility.Visible;
            else
                tbPlaceHolder.Visibility = Visibility.Hidden;
        }
    }
}
