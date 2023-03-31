using System;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        List<int> myIntlist = new List<int> {10,20,40,68,100,280};
        bool numValid = false;
        while (! numValid)
        {
            try
            {
                Console.WriteLine("\nPlease enter the number you wish \nto divide by the list of integers in the database");
                float numDivide = float.Parse(Console.ReadLine());
                if (numDivide == 0)
                {
                    Console.WriteLine("Please enter a number other than 0.");
                }
                else
                {
                    foreach (int myints in myIntlist)
                    {
                        float Divide = myints / numDivide;
                        Console.WriteLine(myints + "/" + numDivide + " = " + Divide);
                    }
                    numValid = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        Console.WriteLine("The program has exited the try/catch block");
    }
}
