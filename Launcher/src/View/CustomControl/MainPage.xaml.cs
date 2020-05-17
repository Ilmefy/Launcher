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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Launcher.src.View.CustomControl
{
    /// <summary>
    /// Logika interakcji dla klasy MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
            if(e.HeightChanged)
            {
                double HeightChange = e.NewSize.Height - e.PreviousSize.Height;
                ViewBox.Height = ViewBox.ActualHeight + HeightChange;
            }
            if(e.WidthChanged)
            {
              
                double WidthChange = e.NewSize.Width - e.PreviousSize.Width;
                ViewBox.Width = ViewBox.ActualWidth + WidthChange;
            }
            
            
            
        }
    }
}