using Ex04.Menus.Interfaces;
using System;
using System.Linq;

namespace Ex04.Menus.Test
{
    internal class CountCapitals : IFuncLeaf
    {
        public void LeafFunction()
        {
            int numOfCapitals;
            string stringToCountCapitalLetters;

            Console.WriteLine("Please enter your sentence:");
            stringToCountCapitalLetters = Console.ReadLine();
            numOfCapitals = stringToCountCapitalLetters.Count(char.IsUpper);
            Console.WriteLine(string.Format("There are {0} capitals in your sentence.{1}{1}", numOfCapitals, Environment.NewLine));
        }
    }
}
