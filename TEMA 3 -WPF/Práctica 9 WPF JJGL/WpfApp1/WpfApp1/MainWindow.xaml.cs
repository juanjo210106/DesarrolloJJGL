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
        public class TodoItem
        {
            public string Title { get; set; }
            public int Completion { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();

            
            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 });
            items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            items.Add(new TodoItem() { Title = "Wash the car", Completion = 0 });

            
            lbTodoList.ItemsSource = items;
        }

        private void BtnShowSelected_Click(object sender, RoutedEventArgs e)
        {
            if (lbTodoList.SelectedItem != null)
            {
                var item = (TodoItem)lbTodoList.SelectedItem;
                MessageBox.Show("Seleccionado: " + item.Title);
            }
            else
            {
                MessageBox.Show("No hay nada seleccionado.");
            }
        }

        private void BtnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            if (lbTodoList.Items.Count > 0)
            {
                lbTodoList.SelectedIndex = lbTodoList.Items.Count - 1;
            }
        }

        private void BtnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            if (lbTodoList.SelectedIndex < lbTodoList.Items.Count - 1)
            {
                lbTodoList.SelectedIndex += 1;
            }
            else
            {
                lbTodoList.SelectedIndex = 0;
            }
        }

        private void BtnSelectCSharp_Click(object sender, RoutedEventArgs e)
        {
            foreach (TodoItem item in lbTodoList.Items)
            {
                if (item.Title.Contains("C#"))
                {
                    lbTodoList.SelectedItem = item;
                    lbTodoList.ScrollIntoView(item);
                    break;
                }
            }
        }

        private void BtnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            lbTodoList.SelectAll();
        }
    }
}