using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    internal class ShowTime : IFuncLeaf
    {
        public void LeafFunction()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("The hour is: {0}:{1}{2}{2}", now.Hour, now.Minute, Environment.NewLine);
        }
    }
}
