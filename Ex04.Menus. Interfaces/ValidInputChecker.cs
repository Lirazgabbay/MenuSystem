using System;

namespace Ex04.Menus.Interfaces
{
    internal class ValidInputChecker
    {
        internal static int GetValidIntFromUser(int i_MaximalValue)
        {
            bool isUserHaveValidAnswer = false;
            int userInput = 0;
            string userAnswer;

            while (!isUserHaveValidAnswer)
            {
                userAnswer = Console.ReadLine();
                isUserHaveValidAnswer = int.TryParse(userAnswer, out userInput);
                if (userInput < 0 || userInput > i_MaximalValue)
                {
                    isUserHaveValidAnswer = false;
                }

                if (!isUserHaveValidAnswer)
                {
                    Console.WriteLine(string.Format("Please enter integer input of the range 0 to {0}", i_MaximalValue));
                }
            }

            return userInput;
        }
    }
}
