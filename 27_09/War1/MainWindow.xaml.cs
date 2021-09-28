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
            int number = Convert.ToInt32(textBox.Text), numb1 = Convert.ToInt32(textBox.Text[0]) - 48, numb2 = Convert.ToInt32(textBox.Text[1]) - 48;
            if (number % 3 == 0)
            {
                label.Content = "Кратность 3м: да";
            }
            else
                label.Content = "Кратность 3м: нет";
            if (number % 2 == 0)
            {
                label1.Content = "Чётность/Нечётность: чётное";
            }
            else
                label1.Content = "Чётность/Нечётность: нечётное";
            label2.Content = "Сумма: " + (numb1 + numb2);
            label3.Content = "Произведение: " + (numb1 * numb2);
        }
    }
}
