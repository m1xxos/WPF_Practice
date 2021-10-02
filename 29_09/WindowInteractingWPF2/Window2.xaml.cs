﻿using System;
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

namespace WindowInteractingWPF2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window, IIInteractiveWindow
    {
        public Window2()
        {
            InitializeComponent();
        }
        #region IInteractiveWindow Members
        public void UpdateWindow(string message)
        {
            label1.Content = message;
        }
        #endregion
    }
}
