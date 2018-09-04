using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private static bool showMenu = true;
        private List<MenuItem> m_MenuItems;
        private int m_Level;

        public SubMenu(int i_Level,string i_ItemName,SubMenu i_PreviousMenu, List<MenuItem> i_MenuItems)
            : base(i_ItemName,i_PreviousMenu)
        {
            m_MenuItems = i_MenuItems;
            m_Level = i_Level;
        }

        public int Level
        {
            get { return m_Level; }
            set { m_Level = value; }
        }

        public List<MenuItem> MenuItems
        {
            get { return m_MenuItems; }
            set { m_MenuItems = value; }
        }

        public override void Run()
        {
            ShowMenu();   
        }

        public int GetUserInputAndValidate()
        {
            string userInputString = null;
            int userInputInt = 0;
            bool userInputValid = false;
            while (!userInputValid)
            {
                userInputString = Console.ReadLine();
                if (int.TryParse(userInputString, out userInputInt))
                {
                    if (userInputInt >= 0 && userInputInt <= m_MenuItems.Count)
                    {
                        userInputValid = true;
                    }
                }

                if (!userInputValid)
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }

            return userInputInt;
        }

        public void ShowMenu()
        {
            int userInput = 0;
            showMenu = true;
            int index = 0;
            string backOrExit = null;
            if(this is MainMenu == true)
            {
                backOrExit = "Exit";
            }
            else
            {
                backOrExit = "Back";
            }

            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("You are in Menu named {0} and its level is {1}", ItemText, m_Level);
                Console.WriteLine("{0}. {1}", index++, backOrExit);
                foreach (MenuItem menuItem in m_MenuItems)
                {
                    Console.WriteLine("{0}. {1}", index++, menuItem.ItemText);
                }

                userInput = GetUserInputAndValidate();
                if (userInput == k_ExitOrBackNumber)
                {
                    showMenu = false;
                    if (this is MainMenu == false)
                    {
                        PreviousMenu.Run();
                    }
                }
                else
                {
                    m_MenuItems[userInput - 1].Run();
                }
            }
        }
    }
}
