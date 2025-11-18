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

namespace NivelAvanzado
{
    /// <summary>
    /// Lógica de interacción para Ventana2.xaml
    /// </summary>
    public partial class Ventana2 : Window
    {
        public String NombreRecogido;
        public String EdadRecogida;
        public Ventana2()
        {
            InitializeComponent();
        }

        private void btn_Aceptar(object sender, RoutedEventArgs e)
        {

            NombreRecogido = txtNombre.Text;
            EdadRecogida = txtEdad.Text;


            this.DialogResult = true;
            this.Close();

        }

        
        private void btn_Cancelar(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
