using Restate.Entities;
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

namespace Restate.Windows
{
    /// <summary>
    /// Interaction logic for clients.xaml
    /// </summary>
    public partial class clients : Window
    {
        private PersonSet_Client _currentPerson = null;

        public clients()
        {
            InitializeComponent();
            LbClients.ItemsSource = App.Context.PersonSet_Client.ToList();
            LbClients.SelectedIndex = 0;
        }

        private void Update()
        {
            LbClients.ItemsSource = App.Context.PersonSet_Client.ToList();
        }

        private void LbClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _currentPerson = LbClients.SelectedItem as PersonSet_Client;
            var currClient = LbClients.SelectedItem as PersonSet_Client;
            if (currClient != null)
            {
                TbFirstName.Text = currClient.PersonSet.FirstName;
                TbMiddleName.Text = currClient.PersonSet.MiddleName;
                TbLastName.Text = currClient.PersonSet.LastName;
                TbEmail.Text = currClient.Email;
                TbPhone.Text = currClient.Phone;
                DgDemands.ItemsSource = currClient.DemandSets.ToList();
                DgSupplies.ItemsSource = currClient.SupplySets.ToList();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            TbFirstName.IsEnabled = true;
            TbMiddleName.IsEnabled = true;
            TbLastName.IsEnabled = true;
            TbPhone.IsEnabled = true;
            TbEmail.IsEnabled = true;

            BtnEdit.Click -= BtnEdit_Click;
            BtnEdit.Content = "Save";
            BtnEdit.Click += setEdit;
        }

        private void setEdit(object sender, RoutedEventArgs e)
        {
            TbFirstName.IsEnabled = false;
            TbMiddleName.IsEnabled = false;
            TbLastName.IsEnabled = false;
            TbPhone.IsEnabled = false;
            TbEmail.IsEnabled = false;

            if (_currentPerson != null)
            {
                _currentPerson.PersonSet.FirstName = TbFirstName.Text;
                _currentPerson.PersonSet.MiddleName = TbMiddleName.Text;
                _currentPerson.PersonSet.LastName = TbLastName.Text;
                _currentPerson.Phone = TbPhone.Text;
                _currentPerson.Email = TbEmail.Text;

                App.Context.SaveChanges();
            }

            BtnEdit.Click -= setEdit;
            BtnEdit.Content = "Edit";
            BtnEdit.Click += BtnEdit_Click;
            Update();
        }
    }
}
