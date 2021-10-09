using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Shapes;

namespace War2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SaveFileDialog _saveDialog = new SaveFileDialog();
        public Window1()
        {
            InitializeComponent();
        }

        public void UpdateWindow(string[] imagesArray)
        {
            foreach (string image in imagesArray)
            {
                listBox.Items.Add(image);
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            image.Source = new BitmapImage(new Uri(listBox.SelectedItem.ToString()));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            _saveDialog.Filter = "Media files (*.PNG)|*.png";
            if (_saveDialog.ShowDialog() == true)
            {
                Bitmap myBitmap = new Bitmap(listBox.SelectedItem.ToString());
                myBitmap.Save(_saveDialog.FileName);
            }
        }
    }
}
