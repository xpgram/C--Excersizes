﻿using System;
using System.Collections.Generic;

namespace Drill17
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName() {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
