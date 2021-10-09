using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace War2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog _openDialog = new OpenFileDialog();
        Window1 wind1 = new Window1();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            _openDialog.Filter = "All Files (*.*)|*.*";
            _openDialog.Multiselect = true;
            if (_openDialog.ShowDialog() == true)
            {
                wind1.UpdateWindow(_openDialog.FileNames);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            wind1.Show();
        }
    }
}
