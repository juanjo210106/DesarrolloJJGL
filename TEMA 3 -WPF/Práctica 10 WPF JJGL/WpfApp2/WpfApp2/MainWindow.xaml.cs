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
        int[,] matriz;
        int n; 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInicializarMatriz(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(dimension.Text, out n))
            {
                matriz = new int[n, n];
                Random rnd = new Random();

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        matriz[i, j] = rnd.Next(0, 100);

                txtSalida.Text = "Matriz generada. Pulsa Imprimir.";
            }
        }


        String s = "";
        private void btnImprimirMatriz(object sender, RoutedEventArgs e)
        {
            if (matriz == null) return;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    s += matriz[i, j] + "\t";
                s += "\n";
            }
            txtSalida.Text = s;
        }

        private void btnImprimirTraspuesta(object sender, RoutedEventArgs e)
        {
            if (matriz == null) return;
            string s = "MATRIZ TRASPUESTA:\n";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    s += matriz[j, i] + "\t";
                s += "\n";
            }
            txtSalida.Text = s;
        }
    }
}