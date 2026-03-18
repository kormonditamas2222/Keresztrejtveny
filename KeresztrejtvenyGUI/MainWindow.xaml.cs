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

namespace KeresztrejtvenyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 6; i <= 15; i++)
            {
                cbSor.Items.Add(i);
                cbOszlop.Items.Add(i);
            }
            for (int i = 1; i <= 10; i++)
            {
                cbIndex.Items.Add(i);
            }
            cbOszlop.SelectedItem = 15;
            cbSor.SelectedItem = 15;
            cbIndex.SelectedItem = 3;   
        }

        private void btnLetrehozas_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < canva.Children.Count; i++)
            {
                if (canva.Children[i] is Grid)
                {
                    canva.Children.Remove(canva.Children[i] as Grid);
                    i--;
                }
            }
            Grid grid = new();
            for (int i = 0; i < (int)cbSor.SelectedItem; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < (int)cbOszlop.SelectedItem; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < grid.RowDefinitions.Count; i++)
            {
                for (int j = 0; j < grid.ColumnDefinitions.Count; j++)
                {
                    TextBox textBox = new();
                    textBox.Text = "-";
                    textBox.TextAlignment = TextAlignment.Center;
                    textBox.Width = 20;
                    textBox.Height = 20;
                    textBox.MaxLength = 1;
                    textBox.MouseDoubleClick += TextBox_MouseDoubleClick;
                    Grid.SetRow(textBox, i);
                    Grid.SetColumn(textBox, j);
                    grid.Children.Add(textBox);
                }
            }
            Canvas.SetTop(grid, 50);
            Canvas.SetLeft(grid, 10);
            canva.Children.Add(grid);
        }

        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBox tb)
            {
                tb.Text = tb.Text == "-" ? "#" : "-";
            }
        }
    }
}