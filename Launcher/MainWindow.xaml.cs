using Launcher.src.View;
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

namespace Launcher
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Top_Bar_Label_MouseEnter(object sender, MouseEventArgs e)
        {
            
            SolidColorBrush solidColorBrush = (SolidColorBrush)TopBar.Background;
            System.Drawing.Color c = System.Windows.Forms.ControlPaint.Light(System.Drawing.Color.FromArgb(solidColorBrush.Color.A, solidColorBrush.Color.R, solidColorBrush.Color.G, solidColorBrush.Color.B));
            (sender as Label).Background = new SolidColorBrush(Color.FromArgb(c.A, c.R, c.G, c.B));
        }

        private void Top_Bar_Label_MouseLeave(object sender, MouseEventArgs e)
        {
            //(sender as Label).Background = TopBar.Background;

            BindingOperations.SetBinding((sender as Label), BackgroundProperty, new Binding("Background") { Source = TopBar });

            //Binding binding = new Binding();
            //binding.Source = (sender as Label);
            //binding.ElementName = "TopBar";
            //(sender as Label).SetBinding(BackgroundProperty, binding);
        }

        private void Button_Exit_App_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)

        {
            Application.Current.Shutdown();
        }

        private void Button_Exit_App_MouseEnter(object sender, MouseEventArgs e)
        {
            Grid_Exit_App.Background = new SolidColorBrush(Colors.Red);
        }

        private void Grid_Exit_App_MouseLeave(object sender, MouseEventArgs e)
        {
            Grid_Exit_App.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Grid_Maximize_App_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush solidColorBrush = (SolidColorBrush)TopBar.Background;
            System.Drawing.Color c = System.Windows.Forms.ControlPaint.Light(System.Drawing.Color.FromArgb(solidColorBrush.Color.A, solidColorBrush.Color.R, solidColorBrush.Color.G, solidColorBrush.Color.B));
            Grid_Maximize_App.Background = new SolidColorBrush(Color.FromArgb(c.A, c.R, c.G, c.B));
        }

        private void Grid_Maximize_App_MouseLeave(object sender, MouseEventArgs e)
        {
            Grid_Maximize_App.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double Height= this.ActualHeight - TopBar.ActualHeight;
            double Width = this.ActualWidth - ExpansionBar.ActualWidth;
            ExpansionBar.Height = Height;
            StackPanel.Height = Height;
            MainPage.Height = Height;
            MainPage.Width = Width;
        }

        private void Grid_Maximize_App_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
        }
    }
}
