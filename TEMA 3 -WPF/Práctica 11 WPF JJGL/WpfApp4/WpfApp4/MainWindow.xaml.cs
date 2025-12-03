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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            if (Tabs.SelectedIndex > 0)
                Tabs.SelectedIndex--;
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            if (Tabs.SelectedIndex < Tabs.Items.Count - 1)
                Tabs.SelectedIndex++;
        }

        private void Seleccionado_Click(object sender, RoutedEventArgs e)
        {
            var tab = (Tabs.SelectedItem as System.Windows.Controls.TabItem);
            string nombre = tab.Header.ToString();

            MessageBox.Show($"Has seleccionado la opción de {nombre}");
        }
    }
}