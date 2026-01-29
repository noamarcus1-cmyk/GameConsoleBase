using GameConsoleBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.DB
{
    // מחלקה סטטית שמדמה בסיס נתונים של משתמשים
    internal static class GameDB
    {
        // רשימה שמכילה את כל המשתמשים הרשומים
        // התחלנו עם משתמש אחד לדוגמה: "tal Simon"
        private static List<User> users = new List<User>()
        {
            new User("tal Simon", "talsi", "1234"),
            new User("noa","1","1")
        };

        // שיטה לרישום משתמש חדש
        // user - אובייקט שמייצג את המשתמש החדש
        // מחזירה true אם הרישום הצליח, אחרת false
        public static bool RegisterUser(User user)
        {
            // בדיקה אם המשתמש שהתקבל הוא null
            if (user == null) return false;

            // בדיקה אם שם המשתמש כבר קיים ברשימה
            if (users.Any(u => u.UserName == user.UserName))
                return false;

            // הוספת המשתמש החדש לרשימה
            users.Add(user);
            return true;
        }

        // שיטה להתחברות משתמש
        // userName - שם המשתמש
        // password - הסיסמה
        // מחזירה את המשתמש אם הפרטים נכונים, אחרת מחזירה null
        public static User Login(string userName, string password)
        {
            // חיפוש משתמש ברשימה לפי שם משתמש וסיסמה
            return users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }

        public static void SaveGameResult(User user, GameResult result)
        {
            var existing = user.GameHistory
                .FirstOrDefault(g => g.GameName == result.GameName);

            if (existing == null)
            {
                user.GameHistory.Add(result);
            }
            else if (result.Score > existing.Score)
            {
                existing.Score = result.Score;
                existing.PlayTime = result.PlayTime;
            }
        }

    }
}
