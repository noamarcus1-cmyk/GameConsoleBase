using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using GameConsoleBase.DB;
using GameConsoleBase.Interfaces;
using GameConsoleBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
	internal class GameScreen:Screen
	{
		private IGamePlay game;
		public GameScreen(IGamePlay game) : base(game.Name)
		{
			this.game = game;
		}

		public override void Show()
		{
			base.Show();
			Console.ForegroundColor = ConsoleColor.Magenta;
			HorizontalCenter("Press any key to start Playing");
			Console.ReadKey();
			game.Play();

            GameResult result = new GameResult(game.Name, game.Score);
            GameDB.SaveGameResult(GameApp.LoggedUser, result);

            Console.WriteLine("Game result saved!");
            Console.ReadKey();

        }

	}
}
