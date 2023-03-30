using System;

namespace branchingAssignemet 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the Total weight of your package?");
            int weight = Convert.ToInt32(Console.ReadLine());
            //intoducing the condition statement to check if the user packet weight exceeds the limit of 50 
            if (weight > 50) 
            {   //if the user package weight exceeds 50 the program prints the message below and exit
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                System.Environment.Exit(-1);
            }
            else
            {   //if the user package input is less than 50 the program continues to get more information
                Console.WriteLine("What is the width of your package?");
            }
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of your package?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of your package?");
            int length = Convert.ToInt32(Console.ReadLine());

            //Calculating the total dimensions
            int totalDimensions = width + length + height;

            //Condition statement to check if the package dimentions exceed the required limit
            if(totalDimensions > 50)
            {   //if the user package dimensions exceeds 50 the program prints the message below and exit
                Console.WriteLine("Package too big to be shipped via Package Express.");
                System.Environment.Exit(-1);

            }   //if the user package dimensions is less than 50 the program continues to the quote
                //calculating the quote to send the user
            int quote = (width * height * length * weight) / 100;

            //Converting the quote to a decimal and displaying it as a currency
            decimal quoteDecimal =(decimal)quote;
            Console.WriteLine("Your estimated total for shipping this package is: " + quoteDecimal.ToString("c") + "\nThank you!");
            Console.ReadLine();
        }   
       
    }
}
