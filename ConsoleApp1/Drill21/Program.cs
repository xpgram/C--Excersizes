using System;
using System.Collections.Generic;

namespace Drill21
{
    static class Program
    {
        public static void run()
        {
            Employee<string> guy = new Employee<string>() {
                FirstName = "Sample",
                LastName = "Student",
                id = 13,
                things = new List<string>() { "Bobble Head", "Blueberry", "Katana" }
            };

            Employee<int> man = new Employee<int>() {
                FirstName = "Sample",
                LastName = "Student",
                id = 19,
                things = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 21 }
            };

            foreach (string s in guy.things)
                Console.WriteLine(s);
            foreach (int i in man.things)
                Console.WriteLine(i);

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
