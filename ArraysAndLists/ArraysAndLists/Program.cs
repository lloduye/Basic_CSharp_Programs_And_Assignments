using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] nameArray1 = new string[] {"John", "Mary", "Jennifer", "Jacob", "Peter", "Claire"};
        Console.WriteLine("Hello there, Type a number between 1-5 and to print out one number from the list");
        int stringSelect= Convert.ToInt32(Console.ReadLine());
        bool validString= false;

        while(!validString)
        {
            try 
            { 
                Console.WriteLine("The name you selected is " + nameArray1[stringSelect]);
                break;
            }
            catch
            {
                Console.WriteLine("Sorry, that number is invalid. Please select a number between 0-5.");
                stringSelect = Convert.ToInt32(Console.ReadLine());
            }
        }
       
      
    }

}