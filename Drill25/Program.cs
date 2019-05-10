using System;
using System.IO;

namespace Drill25 {
    class Program {
        static void Main(string[] args) {
            int n;
            string s;
            string path = @"C:\Users\XPGram\Desktop\log.txt";

            typedPrintln("Please,* girl,* I mean it.** Lemme slide into them dm's.**");
            typedPrintln("What's that number, then?");
            Console.Write("> ");
            while (true)
                if (Int32.TryParse(Console.ReadLine(), out n))
                    break;

            using (StreamWriter writer = new StreamWriter(path))
                writer.WriteLine(n);

            using (StreamReader reader = new StreamReader(path))
                s = reader.ReadToEnd();

            s = s.Replace("\r\n", "");      // Remove newline character

            typedPrintln(s + "?**");
            typedPrintln("Thank you.** Thank you.*** Thank you.**** Thank you.****");
            typedPrintln("Goodbye forever");
        }

        static void typedPrintln(string message) {
            int millis = 20;
            for (int i = 0; i < message.Length; i++) {
                if (message[i] == '*')
                    System.Threading.Thread.Sleep(millis * 16);
                else {
                    Console.Write(message[i]);
                    System.Threading.Thread.Sleep(millis);
                }
            }
            Console.WriteLine();
        }
    }
}
