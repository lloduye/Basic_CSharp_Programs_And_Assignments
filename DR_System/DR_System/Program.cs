using System;

namespace DR_System
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string name= Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course= Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            int page= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string needHelp= Console.ReadLine();
            bool needHelpBool=bool.Parse(needHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences= Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback= Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours= Console.ReadLine();
            int studyHoursNum= Convert.ToInt32(studyHours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}