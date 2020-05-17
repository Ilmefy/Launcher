using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Launcher.src.View
{
    public static class VanillaStyleData
    {
        public static SolidColorBrush Coloristic = new SolidColorBrush(Color.FromRgb(210, 173, 66));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON = new BitmapImage(new Uri("/Resources/ExpansionIcons/vanilla.png", UriKind.Relative));
        public static ImageSource Background = new BitmapImage(new Uri("/Resources/Backgrounds/vanilla.jpg", UriKind.Relative));

    }
    public static class TheBurningCrusadeStyleData
    {
        public static SolidColorBrush Coloristic = new SolidColorBrush(Color.FromRgb(39, 174, 97));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON= new BitmapImage(new Uri("/Resources/ExpansionIcons/tbc.png", UriKind.Relative));
        public static ImageSource Background = new BitmapImage(new Uri("/Resources/Backgrounds/BurningCrusade.jpg", UriKind.Relative));
    }
    public static class WrathOfTheLichKingStyleData
    {
        public static SolidColorBrush Coloristic = new SolidColorBrush(Color.FromRgb(0, 130, 216));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON = new BitmapImage(new Uri("/Resources/ExpansionIcons/wotlk.jpg", UriKind.Relative));
        public static ImageSource Background = new BitmapImage(new Uri("/Resources/Backgrounds/WrathOfTheLichKing.jpg", UriKind.Relative));
    }
    public static class CataclysmStyleData
    {
        public static SolidColorBrush Coloristic = new SolidColorBrush(Color.FromRgb(193, 57, 43));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON = new BitmapImage(new Uri("/Resources/ExpansionIcons/cataclysm.png", UriKind.Relative));
        public static ImageSource Background = new BitmapImage(new Uri("/Resources/Backgrounds/Cataclysm.jpg", UriKind.Relative));
    }
    public static class MistsOfPandariaStyleData
    {

        public static SolidColorBrush Coloristic = new SolidColorBrush(Color.FromRgb(39, 174, 97));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON = new BitmapImage(new Uri("/Resources/ExpansionIcons/mop.png", UriKind.Relative));
        public static ImageSource Background = new BitmapImage(new Uri("/Resources/Backgrounds/MistsOfPandaria.jpg", UriKind.Relative));
    }
    public static class WarlordsOfDraenorStyleData 
    {
        public static SolidColorBrush Coloristic = new SolidColorBrush(Color.FromRgb(211, 84, 0));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON = new BitmapImage(new Uri("/Resources/ExpansionIcons/wod.png", UriKind.Relative));
        public static ImageSource Background = new BitmapImage(new Uri("/Resources/Backgrounds/WarlordsOfDraenor.jpg", UriKind.Relative));
    }
    public static class LegionStyleData
    {
        public static SolidColorBrush Coloristic = new SolidColorBrush(Color.FromRgb(47, 204, 113));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON = new BitmapImage(new Uri("/Resources/ExpansionIcons/legion.png", UriKind.Relative));
        public static ImageSource Background = new BitmapImage(new Uri("/Resources/Backgrounds/Legion.jpg", UriKind.Relative));
    }
    public static class BattleForAzerothStyleData
    {

        public static SolidColorBrush Coloristic = new SolidColorBrush(Color.FromRgb(65, 105, 225));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON = new BitmapImage(new Uri("/Resources/ExpansionIcons/bfa.png", UriKind.Relative));
        public static ImageSource Background = new BitmapImage(new Uri("/Resources/Backgrounds/BattleForAzeroth.jpg", UriKind.Relative));
    }






}
