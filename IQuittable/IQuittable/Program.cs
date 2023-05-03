using System;

namespace IQuittable
{
    // Define main program class
    class Program
    {
        // Define main entry point for program
        static void Main(string[] args)
        {
            // Create an object of type Employee and assign it to a variable of type IQuittable
            IQuittable quittable = new Employee { Name = "John Doe" };
            // Call the Quit() method on the object
            quittable.Quit();
        }
    }
}