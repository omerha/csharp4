using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void ClickEventHandler();

    public abstract class MenuItem
    {
        private string m_ItemText;
        private SubMenu m_PreviousMenu;

        protected MenuItem(string i_MenuItemName, SubMenu i_ParentItem)
        {
            m_ItemText = i_MenuItemName;
            m_PreviousMenu = i_ParentItem;
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
}
