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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

            List<User> items = new List<User>();
            items.Add(new User() { nombre = "Kirri", edad = 19, email = "kirri@ecentia.com", ciudad = "Sevilla" });
            items.Add(new User() { nombre = "Rafa", edad = 34, email = "rafa@ecentia.com", ciudad = "Sevilla" });
            items.Add(new User() { nombre = "Alan", edad = 29, email = "alan@reelio.com", ciudad = "Málaga" });

            lvUsuarios.ItemsSource = items;

        }

        public class User
        {
            public string nombre { get; set; }
            public int edad { get; set; }
            public string email { get; set; }
            public string ciudad { get; set; }
        }
    }
}