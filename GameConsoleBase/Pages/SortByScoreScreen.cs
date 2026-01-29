using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class SortByScoreScreen: Screen
    {
        public SortByScoreScreen() : base("Sort By Score") { }

        public override void Show()
        {
            base.Show();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Magenta;

            var sorted = GameApp.LoggedUser.GameHistory
                .OrderByDescending(g => g.Score);

            foreach (var game in sorted)
                Console.WriteLine($"{game.GameName} - {game.Score}");

            Console.ReadKey();
        }
    }
}
