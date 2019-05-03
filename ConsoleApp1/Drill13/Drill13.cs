using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            MathOps mops = new MathOps();

            mops.TwoIntegers(2, 5);
            mops.TwoIntegers(a: 13, b: 10);

            Console.Read();
        }
    }
}
