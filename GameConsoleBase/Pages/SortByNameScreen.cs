using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class SortByNameScreen : Screen
    {
        public SortByNameScreen() : base("Sort By Name") { }

        public override void Show()
        {
            // קריאה למתודת הבסיס להצגת הכותרת
            base.Show();
            // הגדרת צבעי הטקסט והרקע של הקונסולה
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;

            // מיון היסטוריית המשחקים של המשתמש המחובר לפי שם המשחק בסדר עולה
            var sorted = GameApp.LoggedUser.GameHistory
                .OrderBy(g => g.GameName);

            foreach (var game in sorted)
                // הצגת שם המשחק והציון שלו
                Console.WriteLine($"{game.GameName} - {game.Score}");

            Console.ReadKey();
        }
    }
}
