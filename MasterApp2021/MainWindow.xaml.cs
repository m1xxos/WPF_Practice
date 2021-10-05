using MasterApp2021.Entities;
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

namespace MasterApp2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameMain.Navigate(new Pages.LoginPage());

            var clientsData = File.ReadAllLines(@"C:\Users\bulyn\Downloads\Клиенты.txt");
            for(int i = 0; i < clientsData.Count(); i++)
            {
                var currentClient = clientsData[i].Split('\t');

                var clientForDB = new Client
                {
                    LastName = currentClient[0],
                    FirstName = currentClient[1],
                    Patronymic = currentClient[2],
                    GenderCode = currentClient[3],
                    Phone = currentClient[4],
                    Birthday = DateTime.Parse(currentClient[5]),
                    Email = currentClient[6],
                    RegistrationDate = DateTime.Parse(currentClient[7])
                };
                App.Context.Clients.Add(clientForDB);
                App.Context.SaveChanges();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (FrameMain.CanGoBack)
                FrameMain.GoBack();
        }
    }
}
