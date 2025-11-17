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

namespace WpfApp5
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

        private void Mostrar_Click(object sender, RoutedEventArgs e)
        {
            string titulo = "Texto Seleccionado";
            string mensaje;

            // Comprobamos si el usuario realmente ha seleccionado texto
            if (!string.IsNullOrEmpty(txtEditor.SelectedText))
            {
                // Obtenemos el texto de la propiedad 'SelectedText' del TextBox
                mensaje = $"Has seleccionado:\n\n\"{txtEditor.SelectedText}\"";
            }
            else
            {
                mensaje = "No hay ningún texto seleccionado.";
                titulo = "Información";
            }

            MessageBox.Show(mensaje, titulo, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
