using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class GameHistoryScreen : Screen
    {
        public GameHistoryScreen() : base("Game History") { }

        public override void Show()
        {
            base.Show();

            // קבלת היסטוריית המשחקים של המשתמש המחובר
            var history = GameApp.LoggedUser.GameHistory;

            // בדיקה אם יש היסטוריית משחקים להצגה
            if (history.Count == 0)
            {
                Console.WriteLine("No games played yet.");
            }
            else
            {
                // הצגת פרטי כל משחק בהיסטוריה
                foreach (var game in history)
                {
                    Console.WriteLine($"{game.GameName} | Score: {game.Score} | Played: {game.PlayTime}");
                }
            }

            Console.ReadKey();
        }


    }
}
