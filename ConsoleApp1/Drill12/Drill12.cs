using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num;

            Console.WriteLine("Tell me a number with which I might 'handle'.");
            Console.Write("> ");

            try {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e) {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("Doubled: " + MathOps.Double(num));
            Console.ReadLine();

            Console.WriteLine("Squared: " + MathOps.Square(num));
            Console.ReadLine();

            Console.WriteLine("Tens Place: " + MathOps.FirstDigit(num));
            Console.ReadLine();

            Console.WriteLine("Are you impressed? You may return to your chambers, lest I decide to court you further.");
            Console.Read();
        }
    }
}
