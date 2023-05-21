using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace StudentDatabase
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Create the database 
                context.Database.CreateIfNotExists();


                // Create a new student

                Console.WriteLine("Hello, Welcome to Student Database \nWould you like to register a new student?");
                {
                    string response = Console.ReadLine();

                    if (response == "yes" || response == "yeah" || response == "y")

                    {
                        //Collecting user input

                        Console.WriteLine("What's the student's first name? ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("What's the student's last name? ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Please enter the student's age: ");
                        int age = int.Parse(Console.ReadLine());

                        //Create a new student
                        var student = new Student
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Age = age
                        };

                        // Add the student to the database
                        context.Students.Add(student);
                        context.SaveChanges();

                        Console.WriteLine("Student added successfully!");

                        // Retrieve all students from the database
                        var students = context.Students;
                        Console.WriteLine("All students in the database:");

                        foreach (var s in students)
                        {
                            Console.WriteLine($"Id: {s.Id}, First Name: {s.FirstName}, Last Name: {s.LastName}, Age: {s.Age}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using the program! \nSee you soon");
                    }
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }
        }
    }
}
