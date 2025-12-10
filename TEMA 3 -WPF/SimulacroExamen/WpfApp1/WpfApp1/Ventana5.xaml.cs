using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Ventana5.xaml
    /// </summary>
    public partial class Ventana5 : Window
    {
        public Ventana5()
        {
            InitializeComponent();
            // Llamamos a la función que carga los datos al abrir la ventana
            CargarDatos();
        }

        private void CargarDatos()
        {
            // 1. Cadena de conexión (Asegúrate que la contraseña '1234' es la correcta)
            string connectionString = "Server=localhost;Database=club_deportivo;Uid=root;Pwd=password;";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    // 2. Consulta SQL para pedir los datos
                    string query = "SELECT nombre, dni, actividad, edad FROM socios";

                    // 3. Crear el comando y el adaptador
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);

                    // 4. Llenar una tabla virtual (DataTable) con los datos
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    // 5. Comprobar si hay datos (Requisito del simulacro)
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay participantes registrados.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        // 6. Enlazar la tabla visual (DataGrid) con los datos recibidos
                        dgParticipante.ItemsSource = dt.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error Crítico", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
