using System;
using System.Collections.Generic;

namespace Drill14
{
    class Program
    {
        public static void run()
        {
            MathOps mops = new MathOps();

            int n = 12;
            n = mops.Double(n);
            Console.WriteLine(n);

            decimal m = 19.13m;
            m = mops.Double(m);
            Console.WriteLine(m);

            string str = "14";
            n = mops.Double(str);
            Console.WriteLine(n);

            Console.Read();
        }
    }
}
