using System;
using System.Collections.Generic;

namespace Drill22
{
    static class Program
    {
        public static void run()
        {
            bool done = false;
            string str;
            WeekDay day = WeekDay.Monday;

            while (!done) {
                try {
                    str = StringPrompt("Please enter a day of the week.");
                    day = (WeekDay)Enum.Parse(typeof(WeekDay), str);
                    done = true;
                }
                catch (ArgumentException e) {
                    Console.WriteLine("This is no time for clowning around.");
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }

            Console.WriteLine(day.ToString());

            Console.Read();
        }

        public enum WeekDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
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
