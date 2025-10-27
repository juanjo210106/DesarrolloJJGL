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

namespace Wpf1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private int intentos = 0;
        private const int MAX_INTENTOS = 2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCorregir_Click(object sender, RoutedEventArgs e)
        {
            if (intentos >= MAX_INTENTOS)
            {
                MessageBox.Show("Ya no te quedan intentos.", "Límite alcanzado",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            intentos++;

            // Verificar cuál RadioButton está seleccionado
            if (rbPaquito.IsChecked == true)
            {
                MessageBox.Show("¡Correcto!", "Resultado",
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (intentos < MAX_INTENTOS)
                {
                    MessageBox.Show("Incorrecto. Te quedan "+(MAX_INTENTOS - intentos)+" intento(s).",
                                    "Resultado", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    MessageBox.Show("Incorrecto. Ya no te quedan intentos.",
                                    "Fin del test", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
            }
        }
    }
}