using System;
using System.Collections.Generic;

namespace Drill10
{
    class Program
    {
        public static void run()
        {
            string input;
            int idx;
            bool found;
            string[] strs = new string[] { "What", "Where", "Why", "When", "How" };
            List<string> strl = new List<string>() { "What", "Why", "Where", "Why", "What", "When", "How", "How" };

            // Ask user for input
            Console.WriteLine("Give me a subject.");
            Console.Write("> ");
            input = Console.ReadLine();

            //// Infinite Loop (doesn't increment)
            //int idx = 0;
            //while (idx < strs.Length) {
            //    strs[idx] = strs[idx] + " is " + input + "?!";
            //}

            // Finite Loop - Add user-string to strs array - Use a < comparison
            idx = 0;
            while (idx < strs.Length) {
                strs[idx] = strs[idx] + " is " + input + "?!";
                idx++;
            }

            // Print all strings - Print off strs array, each on a newline
            foreach (string s in strs) {
                Console.WriteLine(s);
            }
            Console.WriteLine("How was your interrogation?");
            Console.ReadLine();
            Console.WriteLine("Thank you.");
            Console.WriteLine();

            // Search for string - Use a <= comparison
            Console.WriteLine("Give me a substring to search for. A question word.");
            Console.Write("> ");
            input = Console.ReadLine();
            idx = 0;
            found = false;
            while (idx <= strs.Length - 1) {
                if (strs[idx].ToLower().Contains(input)) {
                    Console.WriteLine("Index = " + idx);
                    found = true;   // Blocks search-fail text
                    break;          // Stops executing
                }
                idx++;
            }
            if (!found)
                Console.WriteLine("Could not find that question.");

            // Search for a string, showing ~all~ matching indices
            Console.WriteLine("Give me another substring to search for. A question word.");
            Console.Write("> ");
            input = Console.ReadLine();
            idx = 0;
            found = false;
            while (idx <= strl.Count - 1) {
                if (strl[idx].ToLower().Contains(input)) {
                    Console.WriteLine("Index = " + idx);
                    found = true;   // Blocks search-fail text
                }
                idx++;
            }
            if (!found)
                Console.WriteLine("Could not find that question.");

            Console.WriteLine();

            // Iterate through the list with duplicates - Show all - Mark Duplicates - Use foreach
            List<string> tmp = new List<string>();
            foreach (string s in strl) {
                // This just means: if List<string> tmp contains s as a member
                if (tmp.Find(t => (t == s)) != null)
                    Console.WriteLine(s + ", duplicate");
                else {
                    Console.WriteLine(s + ", first");
                    tmp.Add(s);
                }
            }

            // Final wait
            Console.Read();
        }
    }
}
