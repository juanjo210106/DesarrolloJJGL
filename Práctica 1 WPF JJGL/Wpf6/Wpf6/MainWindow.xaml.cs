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

namespace Wpf6
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

        // Evento del botón
        private void btnForzarException(object sender, RoutedEventArgs e)
        {
            try
            {
                // Forzamos una excepción
                int[] numeros = new int[3];
                numeros[5] = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("[ERROR]: Estás introduciendo un número en una posición que no existe... \n[DETALLES DEL ERROR](" + ex + ")");
            }
        }
    }
}