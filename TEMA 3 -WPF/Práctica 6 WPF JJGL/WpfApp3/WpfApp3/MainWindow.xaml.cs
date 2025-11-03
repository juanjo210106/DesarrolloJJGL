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

namespace WpfApp3
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

        private void Button_Click (object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            string mensaje = txtMensaje.Text;

            string textoDelPopup = "El usuario " + nombre + " con email " + email + " envía el mensaje: " + mensaje;
            string tituloDelPopup = "Formulario Enviado";

            MessageBox.Show(textoDelPopup, tituloDelPopup, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}