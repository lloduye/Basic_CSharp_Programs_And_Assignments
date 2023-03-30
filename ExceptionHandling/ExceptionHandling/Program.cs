using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        try 
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberThree);
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);  
        } 
        catch ( FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException )
        {
            Console.WriteLine("Please don't divide by zero");
        }
        finally
        //Typically has database log and Will always run
        {
            Console.ReadLine(); 
        }
    }
}