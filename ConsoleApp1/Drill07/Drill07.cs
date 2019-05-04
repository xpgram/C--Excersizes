using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int loopCount = 0;
            string str = "no master";

            while (str != "yes master")
            {
                Console.WriteLine("Type anything but 'yes master' and I'll repeat myself.");
                Console.WriteLine("Do you understand?");
                Console.Write("> ");
                str = Console.ReadLine();
            }

            do
            {
                loopCount++;
                Console.WriteLine("How many fatalities have you performed recently?");
                Console.Write("> ");
                str = Console.ReadLine();
            } while (str != "yes master");

            switch (loopCount)
            {
                case 1:
                    Console.WriteLine("You catch on quickly.");
                    Console.WriteLine("You have earned 1 golden star.");
                    break;
                case 2:
                    Console.WriteLine("Ha-ha! Almost, you idiot.");
                    goto default;
                default:
                    Console.WriteLine("Congratulations, you pass on a technicality.");
                    break;
            }

            Console.Read();
        }
    }
}
