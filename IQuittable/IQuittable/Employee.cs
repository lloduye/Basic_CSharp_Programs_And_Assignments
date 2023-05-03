using System;
namespace IQuittable
{
    // Defining an Employee class that implements IQuittable
    class Employee : IQuittable
    {
        // Define properties and fields for Employee class
        public string Name { get; set; }
        // Existing code for Employee class goes here

        // Implement Quit() method from IQuittable interface
        public void Quit()
        {
            // Print message indicating that the employee has quit
            Console.WriteLine(Name + " has quit the company.");
        }
    }
}

