using System;

namespace Drill02
{
    class Program
    {
        public static void run()
        {
            string input;

            string course;
            int pageNumber;
            bool helpNeeded;
            string positiveExperiences;
            string otherFeedback;
            int hoursStudied;

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            course = Console.ReadLine();

            Console.WriteLine("What page number?");
            input = Console.ReadLine();
            pageNumber = Convert.ToInt32(input);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            input = Console.ReadLine();
            helpNeeded = Convert.ToBoolean(input);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            input = Console.ReadLine();
            hoursStudied = Convert.ToInt32(input);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
