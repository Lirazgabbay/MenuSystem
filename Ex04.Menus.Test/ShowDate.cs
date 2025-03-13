using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    internal class ShowDate : IFuncLeaf
    {
        public void LeafFunction()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("The Date is: {0}/{1}/{2}{3}{3}", now.Day, now.Month, now.Year, Environment.NewLine);
        }
    }
}
