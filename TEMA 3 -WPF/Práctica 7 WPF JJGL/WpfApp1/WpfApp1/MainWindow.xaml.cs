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

namespace WpfApp1
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
        // Método de un MessageBox simple solo con contenido
        private void MessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esto es un simple mensaje...");
        }

        // Método con un MessageBox con contenido y título
        private void MessageBoxTitle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esto es un simple mensaje...", "Mensaje Informativo");
        }

        // Método de MessageBox con botones de YesNoCancel
        private void MessageBoxButtons_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Este mensaje tiene opciones...", "Opciones", MessageBoxButton.YesNoCancel);
        }


        // Metodo de MessageBox con respuesta cuando se pulsa un botón del MessageBox
        private void MessageBoxResponse_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("¿Quieres guardar los cambios?", "Confirmar", MessageBoxButton.YesNo);

            if (resultado == MessageBoxResult.Yes)
            {
                MessageBox.Show("Has elegido 'Si'...");
            }
            else
            {
                MessageBox.Show("Has elegido 'No'...");
            }
        }

        // Método de MessageBox con un icono
        private void MessageBoxIcon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensaje de advertencia", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        // Método para marcar un boton como por defecto en MessageBox
        private void MessageBoxChoiceDefault_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Se encuentra marcado por defecto 'No'", "Información", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
        }
    }
}