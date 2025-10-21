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

namespace Wpf4
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

        public partial class SpellCheckExample : Page
        {
            public SpellCheckExample()
            {
                StackPanel myStackPanel = new StackPanel();

                //Create TextBox
                TextBox myTextBox = new TextBox();
                myTextBox.Width = 200;

                // Enable spellchecking on the TextBox.
                myTextBox.SpellCheck.IsEnabled = true;

                // Alternatively, the SetIsEnabled method could be used
                // to enable or disable spell checking like this:
                // SpellCheck.SetIsEnabled(myTextBox, true);

                myStackPanel.Children.Add(myTextBox);
                this.Content = myStackPanel;
            }
        }
    }
}