using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Academy of Learning Career College");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What is your name?");
        string studentName= Console.ReadLine();
        Console.WriteLine("What course are you on?");
        string curentCourse = Console.ReadLine();
        Console.WriteLine("What page number?");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
        string needHelp = Console.ReadLine();
        bool needHelpBool =bool.Parse(needHelp);   


    }
}
