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

namespace PrimeraConexion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // DATOS DE CONEXIÓN
        // Ajusta 'Database' con el nombre real de tu base de datos si cambia
        private readonly string connectionString = "Server=localhost; Database=pruebawpf; User=root; Password=password";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Limpiamos la pantalla antes de empezar
            txtResultado.Text = "";

            try
            {
                connection.Open();
                txtResultado.Text += "Conectado. Leyendo datos...\n\n";

                // 1. CONSULTA: El asterisco (*) significa "TRAER TODO"
                string consulta = "SELECT * FROM users";
                MySqlCommand comando = new MySqlCommand(consulta, connection);

                MySqlDataReader lector = comando.ExecuteReader();

                // 2. LEER FILA POR FILA
                while (lector.Read())
                {
                    // Creamos una variable para guardar la línea entera
                    string lineaActual = "";

                    // 3. BUCLE MÁGICO: Recorre todas las columnas automáticamente
                    // lector.FieldCount nos dice cuántas columnas tiene la tabla
                    for (int i = 0; i < lector.FieldCount; i++)
                    {
                        // Agregamos: "NombreColumna: Valor | "
                        string nombreColumna = lector.GetName(i);
                        string valor = lector.GetValue(i).ToString();

                        lineaActual += nombreColumna + ": " + valor + " - ";
                    }

                    // Escribimos la línea completa en la caja de texto y saltamos de línea
                    txtResultado.Text += lineaActual + "\n";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}