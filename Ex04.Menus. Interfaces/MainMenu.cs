using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly string r_Title;
        private readonly List<MenuItem> r_ListItems = new List<MenuItem>();

        public MainMenu(string i_Title)
        {
            r_Title = i_Title;
        }

        public string Title
        {
            get { return r_Title; }
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
            bool isTitle = true;
            int inputString;
            bool isProgramRunning;
            MenuItem itemIterating;

            PrintInfo.DisplayInfo(this.r_ListItems, this.r_Title, isTitle);
            inputString = ValidInputChecker.GetValidIntFromUser(this.r_ListItems.Count);
            if (inputString == 0)
            {
                goto end;
            }

            itemIterating = r_ListItems[inputString - 1];
            Console.Clear();
            isProgramRunning = true;
            while (isProgramRunning)
            {
                itemIterating = itemIterating.Activate();
                if (itemIterating == null)
                {
                    Show();
                    isProgramRunning = false;
                }
            }

            end: ;
        }
    }
}
