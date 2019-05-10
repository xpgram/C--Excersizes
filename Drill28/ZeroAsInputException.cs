using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill28 {
    class ZeroAsInputException : Exception {
        public ZeroAsInputException() : base() { }
        public ZeroAsInputException(string msg) : base(msg) { }
    }
}
