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

        }
    }
}