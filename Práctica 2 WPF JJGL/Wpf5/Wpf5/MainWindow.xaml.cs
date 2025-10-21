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

namespace Wpf5
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

        private void TextBoxEntrada_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string seleccionado = TextBoxEntrada.SelectedText;
            if (!string.IsNullOrEmpty(seleccionado))
            {
                TextBoxSeleccion.Text = "El texto que has seleccionado es: "+seleccionado;
            }
            else
            {
                TextBoxSeleccion.Text = "El texto que has seleccionado es: ";
            }
        }
    }
}