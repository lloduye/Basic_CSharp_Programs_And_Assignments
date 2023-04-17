using System;
using System.Collections.Generic;

namespace MainMethodAssignment
{
    class Program 
    {
     static void Main(string[] args)
        {
            //Instantiate the mathMethod class
            MathMethods math1 = new MathMethods();

            //Call the first method with an int parameter
            Console.WriteLine(math1.MathOp(7));

            //call the second method with a decimal parameter
            Console.WriteLine(math1.MathOp(8.3m));

            // Call the third method with a string parameter
            Console.WriteLine(math1.MathOp("7"));
        }
    }
}
