using System;
using System.Collections.Generic;
using System.Text;
using static Ex04.Menus.Interfaces.MainMenu;

namespace Ex04.Menus.Interfaces
{
    public class MenuItemAction : MenuItem
    {
        private IMenuItemAction m_MenuItemaction;

        public MenuItemAction(string i_ItemName, SubMenu i_PreviousMenu, IMenuItemAction i_MenuItemAction)
            : base(i_ItemName, i_PreviousMenu)
        {
            m_MenuItemaction = i_MenuItemAction;
        }

        public override void Run()
        {
            m_MenuItemaction.Excecute();
            PreviousMenu.Run();
        }
    }
}
