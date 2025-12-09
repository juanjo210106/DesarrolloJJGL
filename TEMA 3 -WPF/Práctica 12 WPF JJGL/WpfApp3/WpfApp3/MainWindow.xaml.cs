using MySql.Data.MySqlClient;
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
        private string conexion = "server=localhost; port=3306; database=pruebawpf; uid=root; pwd=password";

        MySqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            sqlConnection = new MySqlConnection(conexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlConnection.Open();
                txtConexion.Text = "Se ha estsablecido la conexión correctamente con la BBDD";
            }
            catch(Exception m)
            {
                txtConexion.Text = "Error | Se ha producido un error al intentar conectar...: "+m;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 ventana2 = new Window2(conexion);
            ventana2.Show();


        }
    }
}