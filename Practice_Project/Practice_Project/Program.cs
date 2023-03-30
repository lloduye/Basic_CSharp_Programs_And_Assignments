using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args) 
        {
            int num1 = 7;
            int num2 = 12;

            string Results = num1 < num2 ? "Twelve is bigger than seven which makes this statement true" : "Seven is less than twelve which makes this statement false";
            Console.WriteLine(Results);
        }
    }
}