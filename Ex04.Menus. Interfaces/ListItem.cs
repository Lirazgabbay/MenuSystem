using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class ListItem : MenuItem
    {
        private readonly List<MenuItem> r_ItemsList = new List<MenuItem>();

        public ListItem(string i_Title, MenuItem i_Ancestor)
        {
            TitleName = i_Title; 
            Father = i_Ancestor;
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_ItemsList.Add(i_ItemToAdd);
        }

        public void RemoveItem(MenuItem i_ItemToRemove)
        {
            r_ItemsList.Remove(i_ItemToRemove);
        }

        internal override MenuItem Activate()
        {
            bool isTitle = false;
            int userInput;
            MenuItem itemToReturn;

            PrintInfo.DisplayInfo(r_ItemsList, this.TitleName, isTitle);
            userInput = ValidInputChecker.GetValidIntFromUser(this.r_ItemsList.Count);
            itemToReturn = userInput == 0 ? Father : r_ItemsList[userInput - 1];

            return itemToReturn;
        }
    }
}
