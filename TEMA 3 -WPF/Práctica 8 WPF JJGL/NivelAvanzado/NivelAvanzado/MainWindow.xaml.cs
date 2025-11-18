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

namespace NivelAvanzado
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

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Ventana2 ventana = new Ventana2();

            bool? resultado = ventana.ShowDialog();

            if (resultado == true)
            {
                string nombre = ventana.NombreRecogido;
                string edad = ventana.EdadRecogida;

               
                listBox.Items.Add($"Nombre: {nombre} - Edad: {edad}");
            }
        }

        // Botón Salir
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}