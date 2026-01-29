using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using GameConsoleBase.Models;
using System;
using System.Linq;

namespace GameConsoleBase.Pages
{
    //קראנו למחלקה 2 כי הקודמת נעלמה בטעות
    internal class SortByScoreScreen2 : Screen
    {
        public SortByScoreScreen2() : base("Sort Games By Score")
        {
        }

        public override void Show()
        {
            base.Show();

            var user = GameApp.LoggedUser;

            // בדיקה אם יש היסטוריית משחקים
            if (user.GameHistory.Count == 0)
            {
                Console.WriteLine("No games played yet.");
                Console.ReadKey();
                return;
            }

            // מיון לפי ניקוד – מהגבוה לנמוך
            var sorted = user.GameHistory
                .OrderByDescending(g => g.Score)
                .ToList();

            Console.WriteLine("Game History (Sorted By Score):\n");

            foreach (var game in sorted)
            {
                Console.WriteLine(
                    $"Game: {game.GameName} | Score: {game.Score}"
                );
            }

            Console.ReadKey();
        }
    }
}
