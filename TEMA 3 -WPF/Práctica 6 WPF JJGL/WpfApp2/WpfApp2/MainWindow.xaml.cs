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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CutCommandBinding_CanExecute (object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtEditor != null) && (txtEditor.SelectionLength > 0);
        }

        private void CutCommandBinding_Executed (object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Cut();
        }

        private void PasteCommandBinding_CanExecute (Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }

        private void PasteCommandBinding_Executed (Object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Paste();
        }
    }
}