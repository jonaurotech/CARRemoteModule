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
    /// Interaction logic for AssetListView.xaml
    /// </summary>
    public partial class AssetListView : UserControl
    {
        public AssetListView()
        {
            InitializeComponent();
            DataContext = new AssetListViewModel();
        }
    }
}
