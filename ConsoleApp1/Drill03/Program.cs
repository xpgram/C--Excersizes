using System;

namespace Drill03
{
    class Program
    {
        public static void run()
        {
            long integer;
            double real;

            Console.Write("Please enter a number to multiply: ");
            integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: " + (integer * 50));

            Console.Write("Please enter a number to add to: ");
            integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: " + (integer + 25));

            Console.Write("Please enter a number to divide: ");
            real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + (real / 12.5));

            Console.Write("Please enter a number to compare: ");
            integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result (" + integer + " > 50): " + (integer > 50));

            Console.Write("Please enter a number to compute the remainder from: ");
            integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: " + (integer % 7));

            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
