using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            double p1HourlyRate;
            double p1HoursPerWeek;
            double p1Salary;
            double p2HourlyRate;
            double p2HoursPerWeek;
            double p2Salary;

            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine();

            // Person 1's Details
            Console.WriteLine("Person 1");
            Console.WriteLine("Please fill in the following details.");
            Console.Write("Hourly Rate: ");
            p1HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours Worked Per Week: ");
            p1HoursPerWeek = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // Person 2's Details
            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate: ");
            p2HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours Worked Per Week: ");
            p2HoursPerWeek = Convert.ToDouble(Console.ReadLine());

            // Calculate Salaries
            p1Salary = p1HourlyRate * p1HoursPerWeek;
            p2Salary = p2HourlyRate * p2HoursPerWeek;

            Console.WriteLine();

            // Write salary details
            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(p1Salary);

            Console.WriteLine();

            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(p2Salary);

            Console.WriteLine();

            // Final Comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1Salary > p2Salary);

            // End
            Console.Read();
        }
    }
}
