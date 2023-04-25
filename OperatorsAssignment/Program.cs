using System;
using System.Security.Cryptography;

namespace OperatorsAsssignment
{
    class Program
    {
        static void Main()
        {
            Employee Michael = new Employee();
            Michael.FirstName = "Michael";
            Michael.Id = 203;

            Employee Susan = new Employee();
            Susan.FirstName = "Susan";
            Susan.Id = 42;

            Michael.Id += Susan.Id;
            Console.ReadLine();
        }
    }
}