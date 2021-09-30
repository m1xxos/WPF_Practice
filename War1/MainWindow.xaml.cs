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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace War1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window wind1 = new Window1();
            wind1.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window wind2 = new Window2();
            wind2.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window wind3 = new Window3();
            wind3.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window wind4 = new Window4();
            wind4.Show();
        }
    }
}
