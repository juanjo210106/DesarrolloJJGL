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

namespace Wpf3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Creo el contenedor principal Grid
            Grid grid = new Grid();

            // Creo el botón y configuro su aspecto
            Button btn = new Button
            {
                // Texto en negrita 
                FontWeight = FontWeights.Bold,

                // Añado espacio interno al botón
                Padding = new Thickness(100),

                // Centramos el boton dentro del grid
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            // Creamos un WrapPanel para colocar varios TextBlock en línea dentro del botón
            WrapPanel panel = new WrapPanel();

            // Crear el primer TextBlock (color verde)
            TextBlock textoVerde = new TextBlock
            {
                Text = "Texto Verde",           
                Foreground = Brushes.Green,     
                Margin = new Thickness(5, 0, 5, 0)  // Espaciado lateral
            };

            // Crear el segundo TextBlock (color azul)
            TextBlock textoAzul = new TextBlock
            {
                Text = "Texto Azul",
                Foreground = Brushes.Blue,
                Margin = new Thickness(5, 0, 5, 0)  // Espaciado lateral
            };

            // Crear el tercer TextBlock (sin formato)
            TextBlock textoSin = new TextBlock
            {
                Text = "Sin formato",
                Margin = new Thickness(5, 0, 5, 0)  // Espaciado lateral
            };

            // Agragamos los textblock al wrappanel
            panel.Children.Add(textoVerde);
            panel.Children.Add(textoAzul);
            panel.Children.Add(textoSin);

            // Asignamos el wrapPanel como contenido del botón
            btn.Content = panel;

            // Agregamos el btn dentro del grid
            grid.Children.Add(btn);

            // Establecemos el grid como contenido principal de la ventana
            this.Content = grid;
        }
    }
}