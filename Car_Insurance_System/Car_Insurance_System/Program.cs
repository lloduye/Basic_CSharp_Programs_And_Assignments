using System;
using System.ComponentModel.Design;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Write true of false");  
            bool DUIBool=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Qualified?");

            if (age>15 && DUIBool==false && tickets<=3 )
            {
                Console.WriteLine("Congratulations you qualify for a Car insurance!");
            }

            else
            {
                Console.WriteLine("Sorry, you do not qualify for a Car insurance!");
            }
        }
    }
}
