using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill26 {
    class Program {
        static void Main(string[] args) {
            DateTime dt = DateTime.Now;
            int hours;

            Console.WriteLine(dt);
            Console.WriteLine("How many hours would you like to sleep?");
            Console.Write("> ");
            hours = Int32.Parse(Console.ReadLine());        // Errors abound
            dt = dt + new TimeSpan(hours, minutes: 0, seconds: 0);
            Console.WriteLine("It is now " + dt);

            Console.Read();
        }
    }
}
