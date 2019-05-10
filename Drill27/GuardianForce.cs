using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill27 {
    class GuardianForce {
        public const string ATTACK_STR = "{0} attacked for {1} damage.";

        public string name { get; }
        public int power { get; }

        public GuardianForce(string name) : this(name, power: 20) { }
        public GuardianForce(string name, int power) {
            this.name = name;
            this.power = power;
        }

        public void attack() {
            Console.WriteLine(String.Format(ATTACK_STR, this.name, this.power));
        }
    }
}
