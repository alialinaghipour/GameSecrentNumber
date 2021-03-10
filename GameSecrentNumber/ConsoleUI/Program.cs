using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In The Name Of Allah");
            RunApp app = new RunApp();
            app.NewRandomNumber();
            app.Run();
        }
    }
}
