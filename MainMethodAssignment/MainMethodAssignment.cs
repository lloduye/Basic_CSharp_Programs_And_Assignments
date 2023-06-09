﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MathMethods
    {
        //First method that takes in an integer
        public int MathOp(int number)
        {
            return number + 7;
        }

        //Seccond method that takes a decimal
        public decimal MathOp(decimal number)
        {
            // Convert the decimal to an int to perform math operation
            int newnum = Convert.ToInt32(number);
            return newnum * 12;
        }

        //Third mathOp method that takes a string
        public int MathOp(string number)
        {
            //convert the string to an int to perform math operation
            int newnum2 = Convert.ToInt32(number);
            return newnum2 % 3;
        }
    }
}
