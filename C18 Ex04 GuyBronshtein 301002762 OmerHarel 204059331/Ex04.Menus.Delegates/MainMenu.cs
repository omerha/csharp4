using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public sealed class MainMenu : SubMenu
    {
        public MainMenu(int i_Level, string i_ItemName, SubMenu i_PreviousMenu, List<MenuItem> i_MenuItems)
            : base(i_Level, i_ItemName, i_PreviousMenu, i_MenuItems)
        {
        }

        public void Show()
        {
            Run();
        }
    }
}
