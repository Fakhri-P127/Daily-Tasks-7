using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    class Student
    {
        public string Name;
        public string Surname;       
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;            
        }
        public string GetFullname()
        {
            return $"{Name} {Surname}";
        }
    }
}
