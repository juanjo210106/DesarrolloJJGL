using System.Configuration;
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

namespace WpfApp1
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

        private void TabItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string num1 = txtValor1.Text;
            string num2 = txtValor2.Text;

            if (num1 != "" || num2 != "")
            {
                double n1 = double.Parse(num1);
                double n2 = double.Parse(num2);
                if (n1 < 0 || n2 < 0)
                {
                    MessageBox.Show("Se ha producido un error... Los campos debén estar rellenos por un número 0 o más grande de 0", "Error");
                }
                else
                {
                    double result = n1 * n2;
                    txtResultado.Text = result.ToString();
                }


            }
            else
            {
                MessageBox.Show("Los valores no pueden estar vacíos... vuelve a introducirlos para intentarlo de nuevo", "Advertencia");
            }
        }
    }
}