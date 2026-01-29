using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class GameHistoryMenuScreen : MenuScreen
    {
        public GameHistoryMenuScreen() : base("Game History Menu")
        {
            AddMenuItem("Sort by game name", new SortByNameScreen());
            AddMenuItem("Sort by score", new SortByScoreScreen2());
            AddMenuItem("Last played game", new LastGameScreen());
        }
    }
}
