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
                    MainWindow.Instance.TopBar.Background = StyleData.TOP_BAR_BACKGROUND_VANILLA;
                    break;
                case References.Expansions.TheBurningCrusade:
                    MainWindow.Instance.TopBar.Background = StyleData.TOP_BAR_BACKGROUND_THE_BURNING_CRUSADE;
                    break;

                case References.Expansions.WrathOfTheLichKing:
                    MainWindow.Instance.TopBar.Background = StyleData.TOP_BAR_BACKGROUND_WRATH_OF_THE_LICH_KING;
                    break;
                case References.Expansions.Cataclysm:
                    MainWindow.Instance.TopBar.Background = StyleData.TOP_BAR_BACKGROUND_CATACLYSM;
                    break;
                case References.Expansions.MistsOfPandaria:
                    MainWindow.Instance.TopBar.Background = StyleData.TOP_BAR_BACKGROUND_MISTS_OF_PANDARIA;
                    break;
                case References.Expansions.WarlordsOfDraenor:
                    MainWindow.Instance.TopBar.Background = StyleData.TOP_BAR_BACKGROUND_WARLORDS_OF_DRAENOR;
                    break;
                case References.Expansions.Legion:
                    MainWindow.Instance.TopBar.Background = StyleData.TOP_BAR_BACKGROUND_LEGION;
                    break;
                case References.Expansions.BattleForAzeroth:
                    MainWindow.Instance.TopBar.Background = StyleData.TOP_BAR_BACKGROUND_BATTLE_FOR_AZEROTH;
                    break;
            }
            
        }
    }
}
