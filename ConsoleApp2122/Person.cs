﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2122
{
    class Person
    {
        private protected string name;
        public Person(string Name)
        {
            name = Name;
        }
        public string GetName()
        {
            return $"{name}";
        }
    }
}
