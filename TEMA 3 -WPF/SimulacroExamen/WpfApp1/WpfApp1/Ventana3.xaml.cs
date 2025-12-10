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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Ventana3.xaml
    /// </summary>
    public partial class Ventana3 : Window
    {
        public Ventana3()
        {
            InitializeComponent();
        }

        private void btn_baloncesto(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado baloncesto");
            this.Close();
        }

        private void btn_Futbol(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Futbol");
            this.Close();
        }
    }
}
