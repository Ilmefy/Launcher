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
            if(Active)
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
                Grid_MouseLeave(Container, new MouseEventArgs(Mouse.PrimaryDevice,0));
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
            switch(_expansion)
            {
                case References.Expansions.Vanilla:
                    Icon.Source = StyleData.EXPANSION_BUTTON_IMAGE_ICON_VANILLA;
                    Triangle.Fill = StyleData.TOP_BAR_BACKGROUND_VANILLA;
                    break;
                case References.Expansions.TheBurningCrusade:
                    Triangle.Fill = StyleData.TOP_BAR_BACKGROUND_THE_BURNING_CRUSADE;
                    Icon.Source = StyleData.EXPANSION_BUTTON_IMAGE__THE_BURNING_CRUSADE;
                    break;
                case References.Expansions.WrathOfTheLichKing:
                    Triangle.Fill = StyleData.TOP_BAR_BACKGROUND_WRATH_OF_THE_LICH_KING;
                    Icon.Source = StyleData.EXPANSION_BUTTON_IMAGE_ICON_WRATH_OF_THE_LICH_KING;
                    break;
                case References.Expansions.Cataclysm:
                    Triangle.Fill = StyleData.TOP_BAR_BACKGROUND_CATACLYSM;
                    Icon.Source = StyleData.EXPANSION_BUTTON_IMAGE_ICON_CATACLYSM;
                    break;
                case References.Expansions.MistsOfPandaria:
                    Icon.Source = StyleData.EXPANSION_BUTTON_IMAGE_ICON_MISTS_OF_PANDARIA;
                    Triangle.Fill = StyleData.TOP_BAR_BACKGROUND_MISTS_OF_PANDARIA;
                    break;
                case References.Expansions.WarlordsOfDraenor:
                    Icon.Source = StyleData.EXPANSION_BUTTON_IMAGE_ICON_WARLORDS_OF_DRAENOR;
                    Triangle.Fill = StyleData.TOP_BAR_BACKGROUND_WARLORDS_OF_DRAENOR;
                    break;
                case References.Expansions.Legion:
                    Icon.Source = StyleData.EXPANSION_BUTTON_IMAGE_ICON_LEGION;
                    Triangle.Fill = StyleData.TOP_BAR_BACKGROUND_LEGION;
                    break;
                case References.Expansions.BattleForAzeroth:
                    Icon.Source = StyleData.EXPANSION_BUTTON_IMAGE_ICON_BATTLE_FOR_AZEROTH;
                    Triangle.Fill = StyleData.TOP_BAR_BACKGROUND_BATTLE_FOR_AZEROTH;
                    break;
                

                
            }
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = (sender as Grid).Opacity;
            if(Active)
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
