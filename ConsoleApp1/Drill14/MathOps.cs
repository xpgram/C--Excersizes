using System;
using System.Collections.Generic;

namespace Drill14
{
    public class MathOps
    {
        public int Double(int a)
        {
            return a + a;
        }

        public int Double(decimal a)
        {
            return (int)(a * 2);
        }

        public int Double(string a)
        {
            int i = Convert.ToInt32(a);
            return i * i;   // Double, but logarithmically
        }
    }
}
