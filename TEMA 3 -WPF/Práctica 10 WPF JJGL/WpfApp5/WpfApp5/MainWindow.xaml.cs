using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Empleado
    {
        public string Nombre { get; set; }
        public int NumHorasExtra { get; set; }
        public double SalarioSinExtras { get; set; }

        public Empleado(string nombre, double salario)
        {
            Nombre = nombre;
            SalarioSinExtras = salario;
            NumHorasExtra = 0;
        }

        public void HaceHoraExtra(int horas)
        {
            NumHorasExtra += horas;
        }

        public double CalculaSalarioTotal()
        {
            return SalarioSinExtras + (25 * NumHorasExtra);
        }
    }

    public partial class MainWindow : Window
    {
        Empleado[] empleados = new Empleado[15];
        int contador = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAlta(object sender, RoutedEventArgs e)
        {
            string pass = Interaction.InputBox("Introduce la contraseña de administrador", "Seguridad");
            if (pass != "admin")
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }

            if (contador >= 15)
            {
                MessageBox.Show("No caben más empleados");
                return;
            }

            string nombre = Interaction.InputBox("Nombre del empleado:", "Alta");
            string salarioStr = Interaction.InputBox("Salario base:", "Alta");

            if (double.TryParse(salarioStr, out double salario))
            {
                empleados[contador] = new Empleado(nombre, salario);
                contador++;
                MessageBox.Show("Empleado registrado correctamente");
            }
            else
            {
                MessageBox.Show("El salario debe ser un número");
            }
        }

        private void btnHoraExtrasInsertar(object sender, RoutedEventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce tu nombre:", "Fichar Extras");
            bool encontrado = false;

            for (int i = 0; i < contador; i++)
            {
                if (empleados[i].Nombre == nombre)
                {
                    string horasStr = Interaction.InputBox("Número de horas extras:", "Fichar Extras");
                    if (int.TryParse(horasStr, out int horas))
                    {
                        empleados[i].HaceHoraExtra(horas);
                        MessageBox.Show("Horas añadidas correctamente");
                    }
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Error: El usuario no existe");
            }
        }

        private void btnTotalHorasExtras(object sender, RoutedEventArgs e)
        {
            string pass = Interaction.InputBox("Introduce la contraseña de administrador", "Seguridad");
            if (pass != "admin")
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }

            int totalHoras = 0;
            for (int i = 0; i < contador; i++)
            {
                totalHoras += empleados[i].NumHorasExtra;
            }
            MessageBox.Show("Total de horas extras realizadas: " + totalHoras);
        }

        private void btnInformeCompleto(object sender, RoutedEventArgs e)
        {
            string pass = Interaction.InputBox("Introduce la contraseña de administrador", "Seguridad");
            if (pass != "admin")
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }

            string informe = "INFORME COMPLETO:\n\n";

            for (int i = 0; i < contador; i++)
            {
                informe += "Nombre: " + empleados[i].Nombre + "\n";
                informe += "Salario Base: " + empleados[i].SalarioSinExtras + "\n";
                informe += "Horas Extras: " + empleados[i].NumHorasExtra + "\n";
                informe += "Salario Total: " + empleados[i].CalculaSalarioTotal() + "\n";
                informe += "--------------------------------\n";
            }

            MessageBox.Show(informe);
        }
    }
}