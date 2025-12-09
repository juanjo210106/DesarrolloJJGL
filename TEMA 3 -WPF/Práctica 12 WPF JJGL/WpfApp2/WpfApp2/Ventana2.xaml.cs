using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para Ventana2.xaml
    /// </summary>
    public partial class Ventana2 : Window
    {
        private MySqlConnection connection;
        List<User> usuarios;

        public Ventana2(string conexion)
        {
            InitializeComponent();
            connection = new MySqlConnection(conexion);
            usuarios = [];

            try
            {
                connection.Open();
                string sql = "SELECT * FROM users";
                MySqlCommand sqlCommand = new MySqlCommand(sql, connection);

                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("idUsers");
                    string nombre = reader.GetString("Name");
                    string apellido = reader.GetString("Surname");
                    string email = reader.GetString("Email");

                    usuarios.Add(new User(id, nombre, apellido, email));
                }

                dgUsers.ItemsSource = usuarios;
                connection.Close();
            } catch (MySqlException e)
            {
                MessageBox.Show("Error... Se ha producido un error");
            }

            
            
        }
    }
}
