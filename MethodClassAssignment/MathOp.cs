using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{   //Create a class
    class MathOp
    {
        //Create a void method that takes two integers as parameters
        public void Math1(int num1, int num2)
        {
            //Have the method do a math operation on the first integer
            num1 = num1 * 2;
            //display the second integer to the screen
            Console.WriteLine($"The second integer is {num2} ");
        }
    }
}