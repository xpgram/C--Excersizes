using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill12
{
    public class MathOps
    {
        public static int Double(int n)
        {
            return n + n;
        }

        public static int Square(int n)
        {
            return n * n;
        }

        public static int FirstDigit(int n)
        {
            return n % 10;
        }
    }
}
