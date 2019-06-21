using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill28 {
    class Program {
        static void Main(string[] args) {
            int age = 0;

            while (true) {
                try {
                    Console.WriteLine("TELL ME YOUR AGE NOW.");
                    Console.Write("> ");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age == 0)
                        throw new ZeroAsInputException();
                    if (age < 0)
                        throw new NegativeAsInputException();
                    break;
                }
                catch(ZeroAsInputException) {
                    Console.WriteLine("YOU IDIOT> YOU CANNOT BE NOTHING-YEARS OLD. AGAIN.");
                }
                catch(NegativeAsInputException) {
                    Console.WriteLine("YOU FOOL> YOU CANNOT BE TIME-BACKWARDS AGED. ONCE MORE.");
                }
                catch (FormatException) {
                    Console.WriteLine("YOU DUMBEST GUY> YOU CANNOT--I CANNOT EVEN UDERSTAND YOUR SPEAK. TRY.");
                }
                finally {
                    if (age == 0)
                        Console.WriteLine();    // Handy little linebreak between attempts
                }
            }

            Console.WriteLine("YOU ARE WERE BORN IN " + (2019 - age) + " YEAR.\nWHAT YOU THINK OF THAT?\nI AM NUMBER WIZARD.\nI AM CONTROL OF ALL NUMBERS THROUGHOUT OF TIME.");
            Console.Read();
            Console.WriteLine("BYE. I LOVE YOU.");
            System.Threading.Thread.Sleep(120);
        }
    }
}
