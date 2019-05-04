using System;
using System.Collections.Generic;
using System.Linq;

namespace Drill24
{
    static class Program
    {
        static void Main()
        {
            string[] namesf = new string[] { "Joe", "Zell", "Selphie", "Squall", "Rinoa", "Quistis", "Irvine" };
            string[] namesl = new string[] { "Heartilly", "Dincht", "Tilmitt", "Leonhart", "Trepe", "Kinneas" };
            List<Employee> employees = new List<Employee>();

            int c = 1;
            foreach (string fn in namesf) {
                foreach (string ln in namesl) {
                    Employee emp = new Employee() {
                        FirstName = fn,
                        LastName = ln,
                        id = c
                    };
                    c++;
                    employees.Add(emp);
                }
            }

            // List all them boys 'joe'
            List<Employee> joes1 = new List<Employee>();
            foreach (Employee emp in employees) {
                if (emp.FirstName == "Joe")
                    joes1.Add(emp);
            }

            // Li't all 'em again, dem boys 'joe'
            List<Employee> joes2 = employees.Where(x => x.FirstName == "Joe").ToList();

            // List all the new blood
            List<Employee> yunguns = employees.Where(x => x.id > 5).ToList();

            foreach (Employee emp in joes2)
                emp.SayName();
            Console.WriteLine("==============");
            foreach (Employee emp in yunguns)
                emp.SayName();

            Console.Read();
        }

        static string StringPrompt(string msg)
        {
            Console.WriteLine(msg);
            Console.Write("> ");
            return Console.ReadLine();
        }

        static int IntPrompt(string msg)
        {
            bool success = false;
            int n = 0;

            do {
                Console.WriteLine(msg);
                Console.Write("> ");
                try {
                    n = Convert.ToInt32(Console.ReadLine());
                    success = true;
                }
                catch (FormatException e) {
                    Console.WriteLine(e.Message);
                }
            } while (!success);

            return n;
        }
    }
}
