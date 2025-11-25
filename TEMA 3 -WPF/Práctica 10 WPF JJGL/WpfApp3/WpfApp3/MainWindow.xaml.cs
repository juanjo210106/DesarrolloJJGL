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
        List<string> tareas = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Agregar tarea a la lista
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNuevaTarea.Text != "")
            {
                tareas.Add(txtNuevaTarea.Text);
                MessageBox.Show("Tarea registrada en el sistema...", "Información");
                txtNuevaTarea.Clear();
            }
        }

        // Mostrar la siguiente tarea (la que está en la posición 0)
        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            if (tareas.Count > 0)
            {
                MessageBox.Show("Te toca hacer: " + tareas[0]);
            }
            else
            {
                MessageBox.Show("No hay tareas.");
            }
        }

        // Realizar la tarea (Borrar la posición 0)
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (tareas.Count > 0)
            {
                MessageBox.Show("Has hecho la tarea: " + tareas[0]);
                tareas.RemoveAt(0); // Elimina la primera tarea de la lista

                // Actualizamos la lista visible automáticamente (opcional)
                btnMostrarPendientes_Click(null, null);
            }
            else
            {
                MessageBox.Show("¡Estás libre! No hay tareas.");
            }
        }

        // Contar cuántas hay
        private void btnNTareas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tienes " + tareas.Count + " tareas pendientes.");
        }

        // Imprimir toda la lista en el cuadro grande
        private void btnMostrarPendientes_Click(object sender, RoutedEventArgs e)
        {
            txtListado.Clear(); // Limpiar pantalla
            txtListado.Text = "TAREAS PENDIENTES:\n------------------\n";

            // Recorremos la lista para mostrar todo
            for (int i = 0; i < tareas.Count; i++)
            {
                // Escribimos: 1. Comprar pan
                txtListado.Text += (i + 1) + ". " + tareas[i] + "\n";
            }
        }
    }
}