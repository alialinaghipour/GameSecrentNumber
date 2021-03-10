using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Utility
{
    public class UtilityWin
    {
        public void PrintText(string text,ConsoleColor color=ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text+" ");
            Console.ResetColor();
        }
    }
}
