using System;
using System.Collections.Generic;

namespace Drill13
{
    class Program
    {
        public static void run()
        {
            MathOps mops = new MathOps();

            mops.TwoIntegers(2, 5);
            mops.TwoIntegers(a: 13, b: 10);

            Console.Read();
        }
    }
}
