using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using GameConsoleBase.Interfaces;

namespace GameConsoleBase.Pages
{
    internal class UpdateName : Screen
    {
        public UpdateName() : base("Update Name") { }
        //public string Name { get; set; } = "Update Name";
        //public int Score { get; set; } = 0;//ניקוד

        public override void Show()  //הפעולה שמופעלת כאשר המשתמש בוחר לעדכן אתת שם המשתמש
        {
            Console.Clear();
            base.Show();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;//הגדרת צבעים
            Console.WriteLine(" Update Name ");//כותרת
            Console.WriteLine($"Current name: {GameApp.LoggedUser.Name}");//השם הנוכחי של המשתמש

            Console.Write("Enter new name: ");//מבקש מהמשתמש להקליד את השם החדש
            string newName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(newName))//בדיקה שהשם לא ריק או שאין בו רווחים
            {
                GameApp.LoggedUser.Name = newName;
                Console.WriteLine("Name updated successfully!");
                //עדכון השם והודעה על הצלחה
            }
            else
            {
                Console.WriteLine("Invalid name. Name was not changed.");
                //הודעה על שם לא תקין וחזרה לתפריט
            }

            Console.ReadKey();
        }

    }
}