using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateMenu
    {
        private MainMenu m_MainMenu;

        public DelegateMenu()
        {
            m_MainMenu = BuildMenu();
            m_MainMenu.Show();
        }

        private static MainMenu BuildMenu()
        {
            MainMenu mainMenu = new MainMenu(0, "Main Menu", null, new List<MenuItem>());
            SubMenu showDateAndTimeSubMenu = new SubMenu(1, "Show Date/Time", mainMenu, new List<MenuItem>());
            SubMenu showVersionAndCapitalsSubMenu = new SubMenu(1, "Version and Capitals", mainMenu, new List<MenuItem>());
            MenuItemAction showDate = new MenuItemAction("Show Date", showDateAndTimeSubMenu);
            MenuItemAction showTime = new MenuItemAction("Show Time", showDateAndTimeSubMenu);
            MenuItemAction showVersion = new MenuItemAction("Show Version", showVersionAndCapitalsSubMenu);
            MenuItemAction countCapitals = new MenuItemAction("Count Capitals", showVersionAndCapitalsSubMenu);
            mainMenu.MenuItems.Add(showDateAndTimeSubMenu);
            mainMenu.MenuItems.Add(showVersionAndCapitalsSubMenu);
            showDateAndTimeSubMenu.MenuItems.Add(showDate);
            showDateAndTimeSubMenu.MenuItems.Add(showTime);
            showVersionAndCapitalsSubMenu.MenuItems.Add(showVersion);
            showVersionAndCapitalsSubMenu.MenuItems.Add(countCapitals);
            countCapitals.Clicked += Functions.CountCapitalLetters;
            showVersion.Clicked += Functions.ShowVersion;
            showDate.Clicked += Functions.ShowDate;
            showTime.Clicked += Functions.ShowTime;

            return mainMenu;
        }
    }
}
