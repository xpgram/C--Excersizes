using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill20
{
    class Employee : Person, IQuittable
    {
        public int id { get; set; }

        public override void SayName() {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        void IQuittable.Quit() {
            Console.WriteLine("My name is");
            SayName();
            Console.WriteLine("and I want to leave this building.");
            Console.WriteLine("Sayonara, you extra large pizza boy.");
        }

        public static bool operator == (Employee em1, Employee em2) {
            return (em1.id == em2.id);
        }

        public static bool operator != (Employee em1, Employee em2) {
            return (em1.id != em2.id);
        }
    }
}
