using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class MathOps
    {
        public static void Halve(int a, out int b)
        {
            b = a / 2;
        }

        public static void Halve(int a, int b, int c, out int[] d)
        {
            a = a / 2;
            b = b / 2;
            c = c / 2;
            d = new int[] { a, b, c };
        }
    }
}
