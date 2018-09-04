using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuItemAction : MenuItem
    {
        public event ClickEventHandler Clicked;

        public MenuItemAction(string i_MenuItemName, SubMenu i_ParentItem)
            : base(i_MenuItemName, i_ParentItem)
        {
        }

        public override void Run()
        {
            Console.Clear();
            this.OnClicked();
            PreviousMenu.Run();
        }

        protected virtual void OnClicked()
        {
            if (Clicked != null)
            {
                this.Clicked.Invoke();
            }
        }
    }
}
