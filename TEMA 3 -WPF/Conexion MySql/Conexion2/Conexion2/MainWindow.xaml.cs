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

namespace Conexion2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string connectionString = "Server=localhost; Database=pruebawpf; User=root; Password=password";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder resultados = new StringBuilder();
            resultados.AppendLine("-----Datos de Clientes----");

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT idUsers, Name, Surname, Email FROM users";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("idUsers");
                                string nombre = reader.GetString("name");
                                string apellido = reader.GetString("surname");
                                string email = reader.GetString("email");

                                /*
                                if (reader.IsDBNull(reader.GetOrdinal("Surname")))
                                {
                                    apellido = string.Empty;
                                }
                                else
                                {
                                    apellido = reader.GetString("Surname");
                                }*/

                                resultados.AppendLine($"ID: {id}, Nombre: {nombre}, Apellidos: {apellido}, Email: {email}");
                            }
                        }
                    }

                    if (resultados.Length <= 0)
                    {
                        resultados.AppendLine("No se encontraron datos");
                    }

                    tbResultado.Text = resultados.ToString();

                }
                catch (MySqlException ex)
                {
                    tbResultado.Text = $"ERROR al contectar con la BBDD{ex.Message}";
                }
            }
        }
    }
}