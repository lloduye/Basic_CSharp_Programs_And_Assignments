using MethodClassAssignment;
using System;

namespace MathodClassAssignment
{
    class Program
    {
        static void Main(string[] args) 
        {
            //instatiate the class
            MathOp Maths = new MathOp();

            //Call the method in the class, passing in two numbers
            Maths.Math1(2, 20);

            //Call the method in the class specifying the parameters by the name
            Maths.Math1(num1:10 ,num2 : 20);
        }   
    } 
}