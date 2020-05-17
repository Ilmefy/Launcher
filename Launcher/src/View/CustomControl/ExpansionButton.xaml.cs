using Launcher.src.Core;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Launcher.src.View.CustomControl
{
    /// <summary>
    /// Logika interakcji dla klasy ExpansionButton.xaml
    /// </summary>
    public partial class ExpansionButton : UserControl
    {
        private double DefaultOpacity;
        private double ActiveOpacity = 0.9;
        private double ActiveOpacity_MouseEnter = 1.0;
        private double Opacity_MouseEnter = 0.8;
        public ExpansionButton()
        {
            InitializeComponent();
            DefaultOpacity = Container.Opacity;
        }
        private bool _active;

        public bool Active
        {
            get { return _active; }
            set { _active = value; OnActiveChange(); }
        }
        private void OnActiveChange()
        {
            if (Active)
            {
                Border.BorderThickness = new Thickness(2);
                Container.Opacity = 1.0;
                Triangle.Visibility = Visibility.Visible;
                Marker.Opacity = 1.0;
                Grid_MouseEnter(Container, new MouseEventArgs(Mouse.PrimaryDevice, 0));
            }
            else
            {
                Border.BorderThickness = new Thickness(0);
                Container.Opacity = DefaultOpacity;
                Triangle.Visibility = Visibility.Hidden;
                Marker.Opacity = 0.6;
                Grid_MouseLeave(Container, new MouseEventArgs(Mouse.PrimaryDevice, 0));
            }

        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            double OpacityTo = 0;
            if (Active)
                OpacityTo = ActiveOpacity_MouseEnter;
            else
                OpacityTo = Opacity_MouseEnter;
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = (sender as Grid).Opacity;
            opacityAnimation.To = OpacityTo;
            opacityAnimation.Duration = TimeSpan.FromMilliseconds(250);
            (sender as Grid).BeginAnimation(OpacityProperty, opacityAnimation);
        }
        private References.Expansions _expansion;

        public References.Expansions Expansion
        {
            get { return _expansion; }
            set { _expansion = value; OnExpansionChange(); }
        }
        private void OnExpansionChange()
        {
            switch (_expansion)
            {
                case References.Expansions.Vanilla:
                    Icon.Source = VanillaStyleData.EXPANSION_BUTTON_IMAGE_ICON;
                    Triangle.Fill = VanillaStyleData.Coloristic;
                    break;
                case References.Expansions.TheBurningCrusade:
                    Triangle.Fill = TheBurningCrusadeStyleData.Coloristic;
                    Icon.Source = TheBurningCrusadeStyleData.EXPANSION_BUTTON_IMAGE_ICON;
                    break;
                case References.Expansions.WrathOfTheLichKing:
                    Triangle.Fill = WrathOfTheLichKingStyleData.Coloristic;
                    Icon.Source = WrathOfTheLichKingStyleData.EXPANSION_BUTTON_IMAGE_ICON;
                    break;
                case References.Expansions.Cataclysm:
                    Triangle.Fill = CataclysmStyleData.Coloristic;
                    Icon.Source = CataclysmStyleData.EXPANSION_BUTTON_IMAGE_ICON;
                    break;
                case References.Expansions.MistsOfPandaria:
                    Triangle.Fill = MistsOfPandariaStyleData.Coloristic;
                    Icon.Source = MistsOfPandariaStyleData.EXPANSION_BUTTON_IMAGE_ICON;
                    break;
                case References.Expansions.WarlordsOfDraenor:
                    Icon.Source = WarlordsOfDraenorStyleData.EXPANSION_BUTTON_IMAGE_ICON;
                    Triangle.Fill = WarlordsOfDraenorStyleData.Coloristic;
                    break;
                case References.Expansions.Legion:
                    Icon.Source = LegionStyleData.EXPANSION_BUTTON_IMAGE_ICON;
                    Triangle.Fill = LegionStyleData.Coloristic;
                    break;
                case References.Expansions.BattleForAzeroth:
                    Icon.Source = BattleForAzerothStyleData.EXPANSION_BUTTON_IMAGE_ICON;
                    Triangle.Fill = BattleForAzerothStyleData.Coloristic;
                    break;



            }
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {

            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = (sender as Grid).Opacity;
            if (Active)
                opacityAnimation.To = ActiveOpacity;
            else
                opacityAnimation.To = DefaultOpacity;
            opacityAnimation.Duration = TimeSpan.FromMilliseconds(250);
            (sender as Grid).BeginAnimation(OpacityProperty, opacityAnimation);
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            References.CurrentlySelectedExpansion = this.Expansion;
            Cache.CurrentlyActiveExpansionButton = this;
            this.Active = true;
        }
    }
}
