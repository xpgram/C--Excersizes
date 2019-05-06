using System;

namespace Drill06
{
    class Program
    {
        public static void run()
        {
            double packageWeight;
            double packageWidth;
            double packageHeight;
            double packageLength;
            double packageDimensionSum;
            double quote;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.Write("What is the package's weight?  ");
            packageWeight = Convert.ToDouble(Console.ReadLine());

            // First rejection condition
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                return;
            }

            Console.Write("What is the package's width?  ");
            packageWidth = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the package's height?  ");
            packageHeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the package's length?  ");
            packageLength = Convert.ToDouble(Console.ReadLine());

            packageDimensionSum = packageWidth + packageHeight + packageLength;

            // Second rejection condition
            if (packageDimensionSum > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.Read();
                return;
            }

            quote = packageDimensionSum * packageWeight / 100;

            // Display result to the user
            Console.WriteLine(String.Format("Your estimated total for shipping this package is: ${0:0.00}", quote));
            Console.WriteLine("Thank you.");
            Console.Read();
        }
    }
}
