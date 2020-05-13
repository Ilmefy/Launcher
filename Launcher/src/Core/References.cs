using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.src.Core
{
    public static class References
    {
        public enum Expansions
        {
            Vanilla = 0x1,
            TheBurningCrusade = 0x2,
            WrathOfTheLichKing = 0x4,
            Cataclysm = 0x8,
            MistsOfPandaria = 0x10,
            WarlordsOfDraenor = 0x20,
            Legion = 0x40,
            BattleForAzeroth = 0x80
        }
        private static Expansions _currentlySelectedExpansion;

        public static Expansions CurrentlySelectedExpansion
        {
            get { return _currentlySelectedExpansion; }
            set { _currentlySelectedExpansion = value; Events.OnExpansionChange(); }
        }

    }
}
