using GameConsoleBase.BaseClass;
using GameConsoleBase.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class UserMenu : MenuScreen
    {
        public UserMenu() : base("Game Menu")
        {
            AddMenuItem("update name", new UpdateName());
            AddMenuItem("update password", new UpdatePassword());
            AddMenuItem("user details", new UserDetails());
            AddMenuItem("Game History", new GameHistoryMenuScreen());

        }
    }
}
