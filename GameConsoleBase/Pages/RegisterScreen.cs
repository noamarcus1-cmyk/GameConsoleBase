using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using GameConsoleBase.DB;
using GameConsoleBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class RegisterScreen : Screen
    {
        // בנאי (Constructor) של RegisterScreen
        // קורא לבנאי של המחלקה הבסיסית (Screen) ומגדיר את הכותרת של המסך כ-"Register Page"
        public RegisterScreen() : base("Register Page")
        {
        }

        // שיטה שמציגה את מסך ההרשמה
        public override void Show()
        {
            // מציג את הכותרת של המסך
            base.Show();

            // משתנים לשמירת פרטי המשתמש
            string name;
            string userName;
            string password;

            // בקשה מהמשתמש להזין את שמו
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();

            // משתנה שמסמן אם ההרשמה הצליחה
            bool success = false;

            // לולאה שממשיכה עד שההרשמה מצליחה
            while (!success)
            {
                // בקשה מהמשתמש להזין שם משתמש
                Console.WriteLine("enter desired user name  ");
                userName = Console.ReadLine();

                // בקשה מהמשתמש להזין סיסמה
                Console.WriteLine("Enter Password");
                password = Console.ReadLine();

                // בדיקה אם הסיסמה תקינה
                while (!IsValidPassword(password))
                {
                    Console.WriteLine("Enter new Password");
                    password = Console.ReadLine();
                }

                // בדיקה אם שם המשתמש תקין
                while (!IsValidUserName(userName))
                {
                    Console.WriteLine("enter valid userName:");
                    userName = Console.ReadLine();
                }

                // ניסיון לרשום את המשתמש החדש בבסיס הנתונים
                success = GameDB.RegisterUser(new User(name, userName, password));

                // אם ההרשמה הצליחה
                if (success)
                {
                    Console.WriteLine("Registration Successful!");
                }
                // אם ההרשמה נכשלה (למשל, שם המשתמש כבר קיים)
                else
                {
                    Console.WriteLine("Registration Failed! UserName already exists.");
                }
            }

            // מחכה שהמשתמש ילחץ על מקש כלשהו לפני שמנקה את המסך
            Console.ReadKey();
            Console.Clear();
        }

        // שיטה שבודקת אם שם המשתמש תקין
        private bool IsValidUserName(string? userName)
        {
            // שם משתמש חייב להיות לפחות 4 תווים ואינו יכול להיות ריק
            if (string.IsNullOrWhiteSpace(userName) || userName.Length < 4)
            {
                Console.WriteLine("UserName must be at least 4 characters long and cannot be empty.");
                return false;
            }
            return true;
        }

        // שיטה שבודקת אם הסיסמה תקינה
        
        private bool IsValidPassword(string? password)
        {
            // סיסמה חייבת להיות לפחות 6 תווים, להכיל את הסימן '@', ואינה יכולה להיות ריקה
            if (password == null || password.Length < 6 || !password.Contains("@") || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Password must be at least 6 characters long and contain '@' symbol.");
                return false;
            }
            return true;
        }
        
    }
}
