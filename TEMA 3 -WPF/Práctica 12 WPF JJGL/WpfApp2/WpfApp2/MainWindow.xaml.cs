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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string conexion = "server=localhost; port=3306; database=pruebawpf; uid=root; pwd=password";
        MySqlConnection connection;

        public MainWindow()
        {
            InitializeComponent();
            connection = new MySqlConnection(conexion);
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                connection.Open();
                txtConexion.Text = "Se ha establecido la conexión con la BBDD corectamente...";
            }
            catch
            {
                txtConexion.Text = "ERROR |: Se ha producido un error al intentar conectar con la BBDD";
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ventana2 ventana2 = new Ventana2(conexion);
            ventana2.Show();

            
        }
    }
}