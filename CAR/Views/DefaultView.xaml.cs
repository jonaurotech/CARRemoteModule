﻿using CAR.View_models;
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

namespace CAR.Views
{
    /// <summary>
    /// Interaction logic for Default.xaml
    /// </summary>
    public partial class Default : Page
    {
        public Default()
        {
            InitializeComponent();
            DataContext = new DefaultViewModel();
        }

        private void TabItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var tabItem = sender as TabItem;
        }
    }
}
