using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using GameConsoleBase.Interfaces;

namespace GameConsoleBase.Pages
{
    internal class UserDetails : Screen
    {
        public UserDetails() : base("User Details")
        {
        }   
        //public string Name { get; set; } = "User Details";
        //public int Score { get; set; } = 0;

        public override void Show()
        {
            Console.Clear();
            base.Show();
            // הגדרת צבעי הטקסט והרקע
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;
            // הצגת כותרת המסך
            Console.WriteLine(" User Details ");
            // הצגת פרטי המשתמש המחובר
            Console.WriteLine($"Name: {GameApp.LoggedUser.Name}");
            Console.WriteLine($"User Name: {GameApp.LoggedUser.UserName}");

            Console.ReadKey();
        }
    }
}