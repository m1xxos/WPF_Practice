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
using System.Windows.Shapes;

namespace War1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c, D, x1, x2;
            a = Convert.ToDouble(textBox.Text);
            b = Convert.ToDouble(textBox1.Text);
            c = Convert.ToDouble(textBox1_Copy.Text);

            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                label2.Content = "Решение: " + "x1 = " + x1 + "x2 = " + x2;

            }
            else
            {
                label2.Content = "Решение: Действительных корней нет";
            }

        }
    }
}
