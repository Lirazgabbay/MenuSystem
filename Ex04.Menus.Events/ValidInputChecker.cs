using System;

namespace Ex04.Menus.Events
{
    // $G$ DSN-001 (-5) Every  menu should be responsible for managing his i/o.
    internal class ValidInputChecker
    {
        internal static int GetValidIntFromUser(int i_MaximalValue)
        {
            bool userValidAnswer = false;
            int userInput = 0;
            string userAnswer;

            while (!userValidAnswer)
            {
                userAnswer = Console.ReadLine();
                userValidAnswer = int.TryParse(userAnswer, out userInput);
                if (userInput < 0 || userInput > i_MaximalValue)
                {
                    userValidAnswer = false;
                }

                if (!userValidAnswer)
                {
                    Console.WriteLine(string.Format("Please enter integer input of the range 0 to {0}", i_MaximalValue));
                }
            }

            return userInput;
        }
    }
}
