using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace WPFormation.Views.DataBinding
{
    /// <summary>
    /// Interaction logic for Binding.xaml
    /// </summary>
    public partial class Binding : UserControl, INotifyPropertyChanged
    {
        public Binding()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string boundtext;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundtext; }
            set 
            { 
                boundtext = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName= null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); 
        }

        private void btnSet_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BoundText = "Set from code";
        }
    }
}
