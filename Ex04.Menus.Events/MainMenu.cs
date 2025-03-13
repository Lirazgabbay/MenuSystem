using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    // $G$ DSN-999 (-7) why have 4 different menus Design too complicated 2 is enough
    public class MainMenu
    {
        private readonly string r_Title;
        private readonly List<MenuItem> r_ListItems = new List<MenuItem>();

        public MainMenu(string i_Title)
        {
            r_Title = i_Title;
        }

        public void Add(MenuItem i_ItemToAdd)
        {
            r_ListItems.Add(i_ItemToAdd);
        }

        public void Remove(MenuItem i_ItemToRemove)
        {
            r_ListItems.Remove(i_ItemToRemove);
        }

        public void Show()
        {
            bool programIsRunning = true;
            bool isTitle = true;

            PrintInfo.DisplayInfo(this.r_ListItems, this.r_Title, isTitle);
            int userInput = ValidInputChecker.GetValidIntFromUser(this.r_ListItems.Count);
            Console.Clear();
            if (userInput == 0)
            {
                goto endProgram;
            }

            MenuItem itemIterating = r_ListItems[userInput - 1]; ;
            while (programIsRunning)
            {
                itemIterating = itemIterating.Activate();
                if (itemIterating == null)
                {
                    Show();
                    programIsRunning = false;
                }
            }

        endProgram:;
        }
    }
}
