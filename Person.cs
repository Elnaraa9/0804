using System;
using System.Collections.Generic;
using System.Text;

namespace _08_04_2002.Models
{
    public class Person
    {
        internal static object result;

        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person()
        {
        }
    }
}
