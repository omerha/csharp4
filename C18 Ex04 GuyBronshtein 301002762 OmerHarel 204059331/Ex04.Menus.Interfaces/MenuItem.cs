using System;
using System.Collections.Generic;
using System.Text;
using static Ex04.Menus.Interfaces.MainMenu;

namespace Ex04.Menus.Interfaces
{
   public abstract class MenuItem 
    {
        protected const int k_ExitOrBackNumber = 0;
        private string m_ItemText;
        private SubMenu m_PreviousMenu;
        public MenuItem(string i_ItemText,SubMenu i_PreviousMenu)
        {
            m_ItemText = i_ItemText;
            m_PreviousMenu = i_PreviousMenu;
        }
        public string ItemText
        {
            get { return m_ItemText; }
            set { m_ItemText = ItemText; }
        }
        public SubMenu PreviousMenu
        {
            get { return m_PreviousMenu; }
            set { m_PreviousMenu = value; }
        }
        public abstract void Run();
    }
    public class MenuItemAction : MenuItem
    {
        private IMenuItemAction m_MenuItemaction;
        public MenuItemAction(string i_ItemName, SubMenu i_PreviousMenu, IMenuItemAction i_MenuItemAction):base(i_ItemName, i_PreviousMenu)
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
