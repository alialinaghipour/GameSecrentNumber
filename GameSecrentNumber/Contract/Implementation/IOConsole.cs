using Contract.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Tools.Utility;

namespace Contract.Implementation
{
    public class IOConsole : IO
    {
        UtilityConsole _utility;

        public IOConsole()
        {
            _utility = new UtilityConsole();
        }

        public int GetUserAnswer(int answer = 0)
        {
            _utility.PrintText("Answer");
            return int.Parse(Console.ReadLine());
        }

        public void PrintResult(ResultGame result)
        {
                if (result == ResultGame.Correct)
                {
                    _utility.PrintText("You succeeded", ConsoleColor.Green);
                }
                else if (result == ResultGame.Bigger)
                {
                    _utility.PrintText("Your number is bigger", ConsoleColor.Red);
                }
                else if (result == ResultGame.Smaller)
                {
                    _utility.PrintText("Your number is small", ConsoleColor.Yellow);
                }
        }
    }
}
