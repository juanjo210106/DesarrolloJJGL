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

using Microsoft.Win32; // Para OpenFileDialog y SaveFileDialog
using System;            // Para Environment
using System.IO;          // Para File

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
        }

        private void OpenCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            // Filtro para .txt
            dialog.Filter = "Archivos de texto (*.txt)|*.txt";

            // Abrir en "Mis Documentos"
            // Usamos Environment.SpecialFolder.MyDocuments
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (dialog.ShowDialog() == true)
            {
                txtContenido.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void SaveCommand_CanExecute(Object sender, CanExecuteRoutedEventArgs e)
        {
            // Se activa solo si el TextBox tiene contenido
            e.CanExecute = txtContenido != null && !string.IsNullOrWhiteSpace(txtContenido.Text);
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Archivos de texto (*.txt)|*.txt";

            // Abrir en "Mis Documentos"
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Añadir .txt por defecto si no se especifica
            dialog.DefaultExt = ".txt";
            dialog.AddExtension = true;

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, txtContenido.Text);
            }
        }
    }
}