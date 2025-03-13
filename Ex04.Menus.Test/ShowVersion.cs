using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    internal class ShowVersion : IFuncLeaf
    {
        public void LeafFunction()
        {
            Console.WriteLine("App Version: 24.2.4.9504{0}{0}",Environment.NewLine);
        }
    }
}
