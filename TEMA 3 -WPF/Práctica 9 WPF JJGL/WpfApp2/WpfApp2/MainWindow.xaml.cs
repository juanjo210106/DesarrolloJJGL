using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }

        private void CmbColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProperty = cmbColors.SelectedItem as PropertyInfo;

            if (selectedProperty != null)
            {
                Color selectedColor = (Color)selectedProperty.GetValue(null, null);

                this.Background = new SolidColorBrush(selectedColor);
            }
        }
    }
}