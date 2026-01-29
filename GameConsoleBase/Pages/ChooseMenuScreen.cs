using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class ChooseMenuScreen : MenuScreen
    {
        public ChooseMenuScreen() : base("choose Action")
        {
            AddMenuItem("Games" , new GameMenuScreen());
            AddMenuItem("User Menu", new UserMenu());
        }
    }
}
