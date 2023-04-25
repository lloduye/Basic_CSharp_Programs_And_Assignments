using System;
using System.Security.Cryptography;

namespace OperatorsAsssignment
{
    class Program
    {
        static void Main()
        {   

            //Instantiating the two objects from the Emolpyee class
            
            //Object 1
            Employee Michael = new Employee();
            Michael.FirstName = "Michael";
            Michael.Id = 203;

            //Object 2
            Employee Susan = new Employee();
            Susan.FirstName = "Susan";
            Susan.Id = 42;

            Employee.comparisonOp(Michael, Susan); 
                {
                    if (Michael.Id == Susan.Id)
                    {
                    Console.WriteLine(Michael.FirstName + " Has the same ID " + Michael.Id + " as " + Susan.Id);
                    }
                    else
                    {
                    Console.WriteLine(Michael.FirstName + " employee Id is not same as " + Susan.FirstName + " employee Id");
                    }
                };
        }
    }
}