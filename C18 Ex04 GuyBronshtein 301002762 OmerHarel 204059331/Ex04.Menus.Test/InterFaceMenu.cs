using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterFaceMenu
    {
        private MainMenu m_MainMenu;

        public InterFaceMenu()
        {
            BuildMenu();
            m_MainMenu.Run();
        }

        public MainMenu MainMenu
        {
            get { return m_MainMenu; }
        }

        private void BuildMenu()
        {
            m_MainMenu = new MainMenu(0, "Main Menu", null, new List<MenuItem>());
            SubMenu showDateAndTimeSubMenu = new SubMenu(1, "Show Date/Time", m_MainMenu, new List<MenuItem>());
            SubMenu showVersionAndCapitalsSubMenu = new SubMenu(1, "Version and Capitals", m_MainMenu, new List<MenuItem>());
            MenuItemAction showDate = new MenuItemAction("Show Date", showDateAndTimeSubMenu, new Functions.ShowDateHelper());
            MenuItemAction showTime = new MenuItemAction("Show Time", showDateAndTimeSubMenu, new Functions.ShowTimeHelper());
            MenuItemAction showVersion = new MenuItemAction("Show Version", showVersionAndCapitalsSubMenu, new Functions.ShowVersionHelper());
            MenuItemAction countCapitals = new MenuItemAction("Count Capitals", showVersionAndCapitalsSubMenu, new Functions.CountCapitals());
            m_MainMenu.MenuItems.Add(showDateAndTimeSubMenu);
            m_MainMenu.MenuItems.Add(showVersionAndCapitalsSubMenu);
            showDateAndTimeSubMenu.MenuItems.Add(showDate);
            showDateAndTimeSubMenu.MenuItems.Add(showTime);
            showVersionAndCapitalsSubMenu.MenuItems.Add(showVersion);
            showVersionAndCapitalsSubMenu.MenuItems.Add(countCapitals);
        }
    }
}
