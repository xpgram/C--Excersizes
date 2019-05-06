using System;
using System.Collections.Generic;

namespace Drill23
{
    struct Number {
        public decimal Amount { get; set; }

        public Number(decimal dec) {
            this.Amount = dec;
        }

        public static implicit operator Number(decimal dec) {
            return new Number(dec);
        }

        public static implicit operator string(Number n) {
            return n.Amount.ToString();
        }
    }
}
