using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string[] strArray= new string[] { "what", "who", "where", "why", "when", "huh" };
            int[] intArray = new int[] { 3, 5, 8, 2, 7, 0, 4, 1, 9, 7, 6 };
            List<string> strList = new List<string>();
            strList.Add("Roar");
            strList.Add("Rar");
            strList.Add("Rerr");
            strList.Add("Rour");

            bool done = false;
            int index;

            // Phase 1 of my operation
            while (!done)
            {
                Console.WriteLine("Pick an index for integer.");
                Console.Write("> ");
                index = Convert.ToInt32(Console.ReadLine());

                if (index < 0 || index >= intArray.Length)
                    Console.WriteLine("That one doesn't work. Try again.");
                else
                {
                    Console.WriteLine(intArray[index] + ". Nice. Very good. Amazing choice.");
                    done = true;
                }
            }

            // Begin phase 2, whenceforth 66% will be complete
            done = false;
            while (!done)
            {
                Console.WriteLine("Pick a question, too. With your indices.");
                Console.Write("> ");
                index = Convert.ToInt32(Console.ReadLine());

                if (index < 0 || index >= strArray.Length)
                    Console.WriteLine("That one isn't good. Please, another.");
                else
                {
                    Console.WriteLine(strArray[index] + "?! \tYes. Wasn't that exhilirating? I love this question.");
                    done = true;
                }
            }

            // Phase 3, the final countdown
            done = false;
            while (!done)
            {
                Console.WriteLine("Pick an intimidate.");
                Console.Write("> ");
                index = Convert.ToInt32(Console.ReadLine());

                if (index < 0 || index >= strList.Count)
                    Console.WriteLine("I don't like that one. The nummber. Again.");
                else
                {
                    Console.WriteLine(strList[index] + ". \tAmazing. I'm the embodiment of scare.");
                    done = true;
                }
            }

            // Phase 4, the last phase after the last phase 3.
            Console.WriteLine("You have done well. Awesome work great job.");
            Console.Read();
        }
    }
}
