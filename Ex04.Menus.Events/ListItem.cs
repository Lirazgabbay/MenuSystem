using System.Collections.Generic;

namespace Ex04.Menus.Events
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

            PrintInfo.DisplayInfo(r_ItemsList, this.TitleName, isTitle);
            int userChoice = ValidInputChecker.GetValidIntFromUser(this.r_ItemsList.Count);
            MenuItem itemToReturn = userChoice == 0 ? Father : r_ItemsList[userChoice - 1];

            return itemToReturn;
        }
    }
}
