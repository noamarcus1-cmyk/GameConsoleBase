using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsoleBase.BaseClass;

namespace GameConsoleBase.Pages
{
	internal class WelcomeScreen: Screen
	{

		public WelcomeScreen() : base("Welcome to my Game Console")
		{
		}
		public override void Show()
		{
			base.Show();
			Console.ForegroundColor= ConsoleColor.Yellow;
			Console.BackgroundColor= ConsoleColor.Magenta;
			HorizontalCenter("Enjoy a variety of classic games!");
			Console.ResetColor();
			Console.ReadKey();
			Screen next = new MainMenuScreen();
			next.Show();
			Console.Clear();
			HorizontalCenter("Good Bye");
			
		}
	}
}
