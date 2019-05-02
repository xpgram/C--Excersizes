using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            List<int> ints = new List<int>() { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
            int divisor;

            try {
                Console.Write("Enter a number to divide all my friends by: ");
                divisor = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < ints.Count; i++) {
                    ints[i] /= divisor;
                    Console.Write(ints[i] + ", ");
                }

                Console.WriteLine();
                Console.WriteLine("Thank you.");
                Console.ReadLine();
            }
            catch (FormatException e) {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e) {
                Console.WriteLine(e.Message);
            }

            // Post try/catch block code
            Console.WriteLine("Initiating exit procedure. . .");
            Console.ReadLine();
            Console.WriteLine("Stalling. . .");
            Console.ReadLine();
            Console.WriteLine("Beginning to exit. . .");
            Console.ReadLine();
        }
    }
}
