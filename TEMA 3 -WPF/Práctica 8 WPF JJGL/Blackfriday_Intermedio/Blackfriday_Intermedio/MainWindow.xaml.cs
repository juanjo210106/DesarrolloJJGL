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

namespace Blackfriday_Intermedio
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double precioOriginal;

            // Valido que no esté vacío y que sea un número válido
            if (string.IsNullOrEmpty(txtPrecioOriginal.Text) || !double.TryParse(txtPrecioOriginal.Text, out precioOriginal))
            {
                MessageBox.Show("Por favor, introduce un precio válido.", "Error de validación");
                return;
            }

            // Obtengo el descuento que marque el usuario en la interfaz
            double porcentajeDescuento = 0;
            if (rb10.IsChecked == true)
            {
                porcentajeDescuento = 0.10;
            }
            else if (rb20.IsChecked == true)
            {
                porcentajeDescuento = 0.20;
            }
            else if (rb30.IsChecked == true)
            {
                porcentajeDescuento = 0.30;
            }

            // Realizo el calculo del descuento
            double precioFinal = precioOriginal - (precioOriginal * porcentajeDescuento);

            
            // Creamos la nueva ventana pasándole el precio final como parámetro
            VentanaResultado ventana = new VentanaResultado(precioFinal);
            ventana.ShowDialog();
        }
    }
}