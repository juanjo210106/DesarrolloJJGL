using System.Text;
using Microsoft.Win32; // Para OpenFileDialog
using System;             // Para Uri
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging; // Para Bitmap Image
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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

        private void btnCargar_Click(object sender, RoutedEventArgs e)
        {
            // Creo la instancia del OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configuración del filtro
            // "Texto que ve el usuario|*.extension1;*.extension2"
            openFileDialog.Filter = "Archivos de imagen (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg" +
                                    "|Todos los archivos (*.*)|*.*";

            // Mostramos el diálogo y comprobamos si el usuario seleccionó un archivo
            // ShowDialog() devuelve 'true' si el usuario pulsa "Abrir", y 'false' si pulsa "Cancelar".
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    // Obtenemos la ruta completa del archivo seleccionado
                    string rutaArchivo = openFileDialog.FileName;

                    // Cargar la imagen en el control 'Image'
                    // Creamos un BitmapImage y le asignamos la Uri del archivo
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(rutaArchivo);
                    bitmap.EndInit();

                    // Asignamos el bitmap cargado al control Image (imgVisor)
                    imgVisor.Source = bitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }
    }
}