using System.Configuration;
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

        private void txtDni_TextChanged(object sender, TextChangedEventArgs e)
        {
            String[] letras = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"};
            String dni = txtDni.Text;

            if (dni.Length == 8)
            {
                int resto = int.Parse(dni) % 23;
                txtSalida.Text = "La letra del DNI es la " + letras[resto];
            } else
            {
                txtSalida.Text = "Introduce un DNI para comprobar la letra...";
            }
        }
    }
}