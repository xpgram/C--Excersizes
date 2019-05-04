using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int age;
            bool hadDUI;
            int speedingTickets;

            bool approved = true;

            Console.WriteLine("Insurance Applicant Form");
            Console.WriteLine();

            Console.Write("What is your age?  ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Have you ever had a DUI (\"true\" or \"false\")?  ");
            hadDUI = Convert.ToBoolean(Console.ReadLine());

            Console.Write("How many speeding tickets do you have?  ");
            speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Determine applicant approval
            if (age <= 15) approved = false;
            if (hadDUI) approved = false;
            if (speedingTickets > 3) approved = false;

            Console.WriteLine();

            // Report to the applicant
            if (approved)
                Console.WriteLine("You were approved!");
            else
                Console.WriteLine("You have not been approved.");

            Console.Read();
        }
    }
}
