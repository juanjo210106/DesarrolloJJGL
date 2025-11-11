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
        public MainWindow()
        {
            InitializeComponent();
        }

        public void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender; // Recogo el item en el cual se ha hecho click
            string header = item.Header.ToString(); // lo guardo en tipo string

            
            if (header == "Opción 2.2 (Salir)") // Compruebo si coincide con dicha opción para hacer lo que hay dentro del if
            {
                MessageBox.Show("Saliendo de la aplicación... ¡Gracias por utilizarnos!");
                Application.Current.Shutdown();
            } else if (header != "_Opción 2")
            {
                MessageBox.Show("Has elegido: " + header); // devuelvo la opción elegida, es decir, el menuitem
            }
        }
    }
}