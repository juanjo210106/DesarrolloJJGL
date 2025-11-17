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

        private void Mostrar_Click(object sender, RoutedEventArgs e)
        {
            string titulo = "Texto Seleccionado";
            string mensaje;

            // Comprobamos si el usuario ha seleccionado texto
            // usando la propiedad 'SelectedText' del TextBox
            if (!string.IsNullOrEmpty(txtEditor.SelectedText))
            {
                // Obtenemos el texto de la propiedad 'SelectedText'
                mensaje = $"Has seleccionado:\n\n\"{txtEditor.SelectedText}\"";
            }
            else
            {
                mensaje = "No hay ningún texto seleccionado.";
                titulo = "Información";
            }

            // Mostramos el MessageBox
            MessageBox.Show(mensaje, titulo, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}