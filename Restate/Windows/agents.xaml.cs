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
    /// Логика взаимодействия для ManageAgentWindow.xaml
    /// </summary>
    public partial class agents : Window
    {
        private PersonSet_Agent _currentPerson = null;

        public agents()
        {
            InitializeComponent();
            LbAgents.ItemsSource = App.Context.PersonSet_Agent.ToList();
            LbAgents.SelectedIndex = 0;

        }

        private void LbAgents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _currentPerson = LbAgents.SelectedItem as PersonSet_Agent;
            var curAgent = LbAgents.SelectedItem as PersonSet_Agent;
            if (curAgent != null)
            {
                TbFirstName.Text = curAgent.PersonSet.FirstName;
                TbMiddleName.Text = curAgent.PersonSet.MiddleName;
                TbLastName.Text = curAgent.PersonSet.LastName;
                TbDealShare.Text = curAgent.DealShare.ToString();
                DgDemands.ItemsSource = curAgent.DemandSets.ToList();
                DgSupplies.ItemsSource = curAgent.SupplySets.ToList();
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            App.Context.PersonSet_Agent.Remove(LbAgents.SelectedItem as PersonSet_Agent);
            App.Context.SaveChanges();
            Update();
        }
        private void Update()
        {
            LbAgents.ItemsSource = App.Context.PersonSet_Agent.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            TbFirstName.IsEnabled = true;
            TbMiddleName.IsEnabled = true;
            TbLastName.IsEnabled = true;
            TbDealShare.IsEnabled = true;

            BtnEdit.Click -= BtnEdit_Click;
            BtnEdit.Content = "Save";
            BtnEdit.Click += setEdit;
        }

        private void setEdit(object sender, RoutedEventArgs e)
        {
            TbFirstName.IsEnabled = false;
            TbMiddleName.IsEnabled = false;
            TbLastName.IsEnabled = false;
            TbDealShare.IsEnabled = false;

            if (_currentPerson != null)
            {
                _currentPerson.PersonSet.FirstName = TbFirstName.Text;
                _currentPerson.PersonSet.MiddleName = TbMiddleName.Text;
                _currentPerson.PersonSet.LastName = TbLastName.Text;
                _currentPerson.DealShare = int.Parse(TbDealShare.Text);

                App.Context.SaveChanges();
            }

            BtnEdit.Click -= setEdit;
            BtnEdit.Content = "Edit";
            BtnEdit.Click += BtnEdit_Click;
            Update();
        }
    }
}