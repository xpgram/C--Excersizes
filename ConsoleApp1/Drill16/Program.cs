using System;
using System.Collections.Generic;

namespace Drill16
{
    static class Program
    {
        public static void run()
        {
            //MathOps mops = new MathOps();

            int n = IntPrompt("Give me one number five. (Does not have to be 5)");
            MathOps.Halve(n, out n);

            Console.WriteLine("Here: " + n);
            Console.Read();
        }

        static string StringPrompt(string msg)
        {
            Console.WriteLine(msg);
            Console.Write("> ");
            return Console.ReadLine();
        }

        static int IntPrompt(string msg)
        {
            bool success = false;
            int n = 0;

            do {
                Console.WriteLine(msg);
                Console.Write("> ");
                try {
                    n = Convert.ToInt32(Console.ReadLine());
                    success = true;
                }
                catch (FormatException e) {
                    Console.WriteLine(e.Message);
                }
            } while (!success);

            return n;
        }
    }
}
