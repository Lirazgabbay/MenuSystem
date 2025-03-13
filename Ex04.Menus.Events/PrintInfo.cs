using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    internal class PrintInfo
    {
        // $G$ DSN-001 (-5) Every  menu should be responsible for managing his i/o.
        internal static void DisplayInfo(List<MenuItem> i_MenuItems, string i_TitleName, bool i_IsMainMenu)
        {
            int menuItemIndex = 1;
            string lines = "-----------------------";

            Console.WriteLine(string.Format("**{0}**{1}{2}", i_TitleName, Environment.NewLine, lines));
            foreach (MenuItem i_Item in i_MenuItems)
            {
                Console.WriteLine(string.Format("{0}. -> {1}", menuItemIndex, i_Item.TitleName));
                menuItemIndex++;
            }

            Console.WriteLine(string.Format("{0}", i_IsMainMenu ? "0. -> Exit" : "0. -> Back"));
            Console.WriteLine(string.Format("{0}{1}Enter your request: (1 to {2} or press '0' to Back).", lines, Environment.NewLine, menuItemIndex - 1));
        }
    }
}
