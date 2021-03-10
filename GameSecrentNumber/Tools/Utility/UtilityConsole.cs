using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tools.Utility
{
    public class UtilityConsole
    {
        public void PrintText(string text,ConsoleColor color=ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text+" ");
            Console.ResetColor();
        }
    }
}
