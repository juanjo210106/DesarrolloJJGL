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
        private const string usuarioCorrecto = "admin";
        private const string passwordCorrecta = "1234";
        private const int MAX_PASSWORD = 8;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Password.Trim();

            if (usuario == usuarioCorrecto && password == passwordCorrecta)
            {
                MessageBox.Show("Inicio de sesión correcto", "Login",
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Limitar a 8 caracteres
            if (txtPassword.Password.Length > MAX_PASSWORD)
            {
                txtPassword.Password = txtPassword.Password.Substring(0, MAX_PASSWORD);
                MessageBox.Show("La contraseña no puede tener más de 8 caracteres.",
                                "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}