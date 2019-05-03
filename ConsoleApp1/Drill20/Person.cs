using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();
    }
}
