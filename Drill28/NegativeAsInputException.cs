using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill28 {
    class NegativeAsInputException : Exception {
        public NegativeAsInputException() : base() { }
        public NegativeAsInputException(string msg) : base(msg) { }
    }
}
