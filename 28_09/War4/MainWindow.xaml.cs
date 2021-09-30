using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace War4
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

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            textBlock.Text = calendar.SelectedDate.ToString();
        }

        private void datepicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            textBlock.Text = datepicker.SelectedDate.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = DateTime.Now.ToString();
            var request = (HttpWebRequest)WebRequest.Create("http://worldtimeapi.org/api/timezone/Europe/Moscow/");
            request.Method = "get";
            WebResponse response = request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            textBlock2.Text = responseString;
        }
    }
}
