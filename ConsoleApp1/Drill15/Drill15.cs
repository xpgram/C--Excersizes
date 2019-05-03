using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            MathOps mops = new MathOps();

            int n = IntPrompt("Give me one number.");
            int n2;
            string tmp = StringPrompt("Give me one 'a second' number. (Optional)");

            if (tmp.Length != 0) {
                n2 = Convert.ToInt32(tmp);      // I'm just skipping the error catch in this one...
                n = mops.Multiply(n, n2);
            }
            else
                n = mops.Multiply(n);

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
