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

namespace WpfApp3
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MySqlConnection sqlConnection;
        List<Usuario> usuarios;

        public Window2(string conexion)
        {
            InitializeComponent();

            sqlConnection = new MySqlConnection(conexion);
            usuarios = [];

            try
            {
                sqlConnection.Open();
                string sql = "SELECT * FROM users";

                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("idUsers");
                    string nombre = reader.GetString("Name");
                    string apellido = reader.GetString("Surname");
                    string email = reader.GetString("Email");

                    usuarios.Add(new Usuario(id, nombre, apellido, email));
                }

                dgUsuarios.ItemsSource = usuarios;
                sqlConnection.Close();
            } catch (Exception e)
            {
                MessageBox.Show("Error... Se ha producido un error");
            }
        }
    }
}
