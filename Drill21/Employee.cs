using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee<T> : Person, IQuittable
    {
        public int id { get; set; }
        public List<T> things { get; set; }

        public override void SayName() {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        void IQuittable.Quit() {
            Console.WriteLine("My name is");
            SayName();
            Console.WriteLine("and I want to leave this building.");
            Console.WriteLine("Sayonara, you extra large pizza boy.");
        }

        public static bool operator == (Employee<T> em1, Employee<T> em2) {
            return (em1.id == em2.id);
        }

        public static bool operator != (Employee<T> em1, Employee<T> em2) {
            return (em1.id != em2.id);
        }
    }
}
