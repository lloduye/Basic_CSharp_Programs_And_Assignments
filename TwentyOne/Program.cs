using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main()
        {
            Console.Readline("Welcome to the Grand Hotel Casino. Let's start by telling me your name.");
            string playerName = Console.Readline();
            Console.ReadLine();
            Console.WriteLine("And How much money did you bring today?");
            Console.ReadLine();
        }
    }
}