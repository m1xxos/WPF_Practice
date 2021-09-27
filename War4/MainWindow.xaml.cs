﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Выборка всех режимов редактирования InkCanvas.
            lstEditingMode.Items.Add(InkCanvasEditingMode.Ink);
            lstEditingMode.Items.Add(InkCanvasEditingMode.EraseByPoint);
            lstEditingMode.SelectedItem = inkCanvas.EditingMode;
        }
        private void lstEditingMode_SelectionChanged(object sender,
       SelectionChangedEventArgs e)
        {
        }
    }
}
