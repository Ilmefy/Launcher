using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Launcher.src.View
{
    public static class StyleData
    {
        public static SolidColorBrush TOP_BAR_BACKGROUND_VANILLA = new SolidColorBrush(Color.FromRgb(210, 173, 66));
        public static SolidColorBrush TOP_BAR_BACKGROUND_THE_BURNING_CRUSADE = new SolidColorBrush(Color.FromRgb(39, 174, 97));
        public static SolidColorBrush TOP_BAR_BACKGROUND_WRATH_OF_THE_LICH_KING = new SolidColorBrush(Color.FromRgb(0, 130, 216));
        public static SolidColorBrush TOP_BAR_BACKGROUND_CATACLYSM = new SolidColorBrush(Color.FromRgb(193, 57, 43));
        public static SolidColorBrush TOP_BAR_BACKGROUND_MISTS_OF_PANDARIA = new SolidColorBrush(Color.FromRgb(39, 174, 97));
        public static SolidColorBrush TOP_BAR_BACKGROUND_WARLORDS_OF_DRAENOR = new SolidColorBrush(Color.FromRgb(211, 84, 0));
        public static SolidColorBrush TOP_BAR_BACKGROUND_LEGION = new SolidColorBrush(Color.FromRgb(47, 204, 113));
        public static SolidColorBrush TOP_BAR_BACKGROUND_BATTLE_FOR_AZEROTH = new SolidColorBrush(Color.FromRgb(65, 105, 225));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON_VANILLA = new BitmapImage(new Uri("/Resources/ExpansionIcons/vanilla.png", UriKind.Relative));
        public static ImageSource EXPANSION_BUTTON_IMAGE__THE_BURNING_CRUSADE = new BitmapImage(new Uri("/Resources/ExpansionIcons/tbc.png", UriKind.Relative));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON_WRATH_OF_THE_LICH_KING = new BitmapImage(new Uri("/Resources/ExpansionIcons/wotlk.jpg", UriKind.Relative));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON_CATACLYSM = new BitmapImage(new Uri("/Resources/ExpansionIcons/cataclysm.png", UriKind.Relative));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON_MISTS_OF_PANDARIA = new BitmapImage(new Uri("/Resources/ExpansionIcons/mop.png", UriKind.Relative));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON_WARLORDS_OF_DRAENOR = new BitmapImage(new Uri("/Resources/ExpansionIcons/wod.png", UriKind.Relative));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON_LEGION = new BitmapImage(new Uri("/Resources/ExpansionIcons/legion.png", UriKind.Relative));
        public static ImageSource EXPANSION_BUTTON_IMAGE_ICON_BATTLE_FOR_AZEROTH = new BitmapImage(new Uri("/Resources/ExpansionIcons/bfa.png", UriKind.Relative));
    }
}
