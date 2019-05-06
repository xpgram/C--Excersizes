using System;
using System.Text;

namespace Drill08
{
    class Program
    {
        public static void run()
        {
            string s1 = "Yes";
            string s2 = "No";
            string s3 = "I dunno";
            StringBuilder sb = new StringBuilder();

            Console.WriteLine(s1 + ' ' + s2 + ' ' + s3);
            Console.WriteLine((s1 + ' ' + s3 + ' ' + s2).ToUpper());

            sb.Append("I'll repeat myself. ");
            for (int i = 0; i < 20; i++)
            {
                sb.Append("And I'll do it again. ");
            }
            sb.Append("Until I can't do it no more.");

            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
