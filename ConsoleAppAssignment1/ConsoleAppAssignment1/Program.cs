using System;
using System.Collections.Generic;

namespace Assignment4 
{
    class Program
    {
        static void Main()
        {
            List<string> colors = new List<string> { "red", "green", "blue", "yellow", "black", "white" };
            Console.WriteLine("What is your favourite color? ");
            string userfavColor = Console.ReadLine();
            int index = colors.FindIndex(a => a.Contains(userfavColor));

            foreach (string color in colors)
            {
                if (userfavColor == color)
                {
                    Console.WriteLine(userfavColor + " is on index " + index + " on the list");
                }
                else
                {
                    Console.WriteLine("Sorry " + userfavColor + " is not on the list");
                }
            }
        }
    }
}
