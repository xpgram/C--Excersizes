using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main()
        {
            Employee guy = new Employee() {
                FirstName = "Sample",
                LastName = "Student",
                id = 13
            };

            Employee man = new Employee() {
                FirstName = "Sample",
                LastName = "Student",
                id = 19
            };

            if (man != guy) {
                Console.WriteLine("But not for long.");
            }

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
