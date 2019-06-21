using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill27 {
    class Program {
        static void Main(string[] args) {
            var Ifrit = new GuardianForce("Ifrit");
            Ifrit.attack();

            Console.Read();
        }
    }
}
