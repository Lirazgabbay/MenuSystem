using System;
using System.Linq;

namespace Ex04.Menus.Test
{
    public class EventsMethods
    {
        public static void ShowDate()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("The Date is: {0}/{1}/{2}{3}{3}", now.Day, now.Month, now.Year, Environment.NewLine);
        }

        public static void ShowTime()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("The hour is: {0}:{1}{2}{2}", now.Hour, now.Minute, Environment.NewLine);
        }

        public static void ShowVersion()
        {
            Console.WriteLine("App Version: 24.2.4.9504{0}{0}", Environment.NewLine);
        }

        public static void CountCapitals()
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
