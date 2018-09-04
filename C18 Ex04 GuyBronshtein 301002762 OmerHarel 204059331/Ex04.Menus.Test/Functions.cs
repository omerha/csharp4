using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
   public static class Functions
    {
        public class ShowDateHelper : MainMenu.IMenuItemAction
        {
            public void Excecute()
            {
                ShowDate();
            }
        }

        public static void ShowDate()
        {
            string date = string.Format("The date is: {0}", DateTime.Now.Date.ToShortDateString());
            PrintToUI(date);
        }

        public class ShowTimeHelper : MainMenu.IMenuItemAction
        {
            public void Excecute()
            {
                ShowTime();
            }
        }

        public static void ShowTime()
        {
            string time = string.Format("The time is: {0}", DateTime.Now.ToString("HH:mm:ss"));
            PrintToUI(time);
        }

        public class ShowVersionHelper : MainMenu.IMenuItemAction
        {
            public void Excecute()
            {
                ShowVersion();
            }
        }

        public static void ShowVersion()
        {
            string version = "The version is: 18.3.4.0";
            PrintToUI(version);
        }

        public class CountCapitals : MainMenu.IMenuItemAction
        {
            public void Excecute()
            {
                CountCapitalLetters();
            }
        }

        public static void CountCapitalLetters()
        {
            string userInput = null;
            int numOfCapitalLetters = 0;
            string finalMessage = null;
            Console.Clear();
            Console.WriteLine("Please type a sentence");
            userInput = Console.ReadLine();
            foreach(char letter in userInput)
            {
                if(char.IsUpper(letter))
                {
                    numOfCapitalLetters++;
                }
            }

            finalMessage = string.Format("The sentence \"{0}\" has {1} Capital letters", userInput, numOfCapitalLetters);
            PrintToUI(finalMessage);
        }

        private static void PrintToUI(string i_Text)
        {
            Console.Clear();
            Console.WriteLine(i_Text);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
    }
}
