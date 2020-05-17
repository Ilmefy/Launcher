using Launcher.src.View;
using Launcher.src.View.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Launcher.src.Core
{
    public static class Events
    {
        public static void CurrentlySelectedExpansionChanged()
        {
            
        }

        public  static void CurrentlyActiveExpansionButtonChanged(ExpansionButton oldValue, ExpansionButton newValue)
        {
            if(oldValue!=null)
                oldValue.Active = false;
            newValue.Active = true;
        }
        public static void OnExpansionChange()
        {
            switch (References.CurrentlySelectedExpansion) 
            {
                case References.Expansions.Vanilla:
                    MainWindow.Instance.TopBar.Background = VanillaStyleData.Coloristic;
                    MainWindow.Instance.MainPage.Background.Source = VanillaStyleData.Background;
                    break;
                case References.Expansions.TheBurningCrusade:
                    MainWindow.Instance.TopBar.Background = TheBurningCrusadeStyleData.Coloristic;
                    MainWindow.Instance.MainPage.Background.Source = TheBurningCrusadeStyleData.Background;
                    break;

                case References.Expansions.WrathOfTheLichKing:
                    MainWindow.Instance.TopBar.Background = WrathOfTheLichKingStyleData.Coloristic;
                    MainWindow.Instance.MainPage.Background.Source = WrathOfTheLichKingStyleData.Background;
                    break;
                case References.Expansions.Cataclysm:
                    MainWindow.Instance.TopBar.Background = CataclysmStyleData.Coloristic;
                    MainWindow.Instance.MainPage.Background.Source = CataclysmStyleData.Background;
                    break;
                case References.Expansions.MistsOfPandaria:
                    MainWindow.Instance.TopBar.Background = MistsOfPandariaStyleData.Coloristic;
                    MainWindow.Instance.MainPage.Background.Source = MistsOfPandariaStyleData.Background;
                    break;
                case References.Expansions.WarlordsOfDraenor:
                    MainWindow.Instance.TopBar.Background = WarlordsOfDraenorStyleData.Coloristic;
                    MainWindow.Instance.MainPage.Background.Source = WarlordsOfDraenorStyleData.Background;
                    break;
                case References.Expansions.Legion:
                    MainWindow.Instance.TopBar.Background = LegionStyleData.Coloristic;
                    MainWindow.Instance.MainPage.Background.Source = LegionStyleData.Background;
                    break;
                case References.Expansions.BattleForAzeroth:
                    MainWindow.Instance.TopBar.Background = BattleForAzerothStyleData.Coloristic;
                    MainWindow.Instance.MainPage.Background.Source = BattleForAzerothStyleData.Background;
                    break;
            }
            
        }
    }
}
