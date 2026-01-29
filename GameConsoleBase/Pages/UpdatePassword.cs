using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using GameConsoleBase.Interfaces;

namespace GameConsoleBase.Pages
{
    internal class UpdatePassword : Screen
    {
        //public string Name { get; set; } = "Update Password";
        //public int Score { get; set; } = 0;

        public UpdatePassword() : base("Update Password") { }

        public override void Show()//הפעולה שמופעלת כאשר המשתמש בוחר לעדכן את הסיסמה
        {
            Console.Clear();

            base.Show();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;//הגדרת צבעים
            Console.WriteLine(" Update Password ");

            Console.Write("Enter current password: ");//סיסמה נוכחית
            string currentPassword = Console.ReadLine();

            //בדיקה שהסיסמה הנוכחית תואמת את הסיסמה של המשתמש המחובר
            if (currentPassword != GameApp.LoggedUser.Password)
            {
                //אם הסיסמה לא תואמת, מציג הודעת שגיאה ומחזיר לתפריט
                Console.WriteLine("Wrong password!");
                Console.ReadKey();
                return;
            }

            //בקשה מהמשתמש להקליד סיסמה חדשה
            Console.Write("Enter new password: ");
            string newPassword = Console.ReadLine();

            //בדיקה שהסיסמה החדשה תקינה (לפחות 6 תווים)
            if (string.IsNullOrWhiteSpace(newPassword) || newPassword.Length < 6)
            {
                //אם הסיסמה לא תקינה, מציג הודעת שגיאה
                Console.WriteLine("Password must be at least 6 characters.");
            }
            else
            {
                //עדכון הסיסמה והודעה על הצלחה
                GameApp.LoggedUser.Password = newPassword;
                Console.WriteLine("Password updated successfully!");
            }

            Console.ReadKey();
        }
    }
}