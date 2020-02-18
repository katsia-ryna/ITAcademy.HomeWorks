using System;
using System.Collections.Generic;
using System.Text;

namespace HW10.Task2
{
    class Person
    {
        string _Name;
        sbyte _Age;
        public Person(string name, sbyte age)
        {
            _Name = name;
            _Age = age;
        }

        public string Info
        {
            get
            {
                return $"{_Name}s age is {_Age}";
            }
        }
    }
}
