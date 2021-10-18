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
using Restate.Windows;

namespace Restate
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

        private void buttonAgents_Click(object sender, RoutedEventArgs e)
        {
            Window agnent = new Windows.agents();
            agnent.Show();
        }

        private void buttonClients_Click(object sender, RoutedEventArgs e)
        {
            Window client = new clients();
            client.Show();
        }
    }
}
