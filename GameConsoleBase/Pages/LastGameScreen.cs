using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class LastGameScreen : Screen
    {
        public LastGameScreen() : base("Last Played Game") { }

        public override void Show()
        {
            base.Show();
            // קבלת המשחק האחרון שהמשתמש שיחק
            var lastGame = GameApp.LoggedUser.GameHistory
                .OrderByDescending(g => g.PlayTime)
                .FirstOrDefault();

            // בדיקה אם יש משחקים להצגה
            if (lastGame == null)
                // אם אין משחקים, מציג הודעה מתאימה
                Console.WriteLine("No games played yet.");
            else
                // הצגת פרטי המשחק האחרון
                Console.WriteLine($"{lastGame.GameName} - {lastGame.Score}");

            Console.ReadKey();
        }

    }
}
