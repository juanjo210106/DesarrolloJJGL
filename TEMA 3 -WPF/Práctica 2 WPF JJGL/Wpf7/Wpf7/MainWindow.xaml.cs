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

namespace Wpf7
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

        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            string nombre = TextBoxUsuario.Text;
            if (string.IsNullOrEmpty(nombre))
                nombre = "usuario";
            MessageBox.Show($"Hola, {nombre}");
        }
    }
}