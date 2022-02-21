using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    class Group
    {
        public string No;
        public int Limit;
        private Student[] _students;       
        public Group(string no, int limit)
        {
            _students = new Student[0];
            No = no;
            Limit = limit;                        
        }
        public void AddStudent(Student student)
        {
            if(_students.Length < Limit) 
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length-1] = student;          
            }
            else
            {
                Console.WriteLine("Group has reached it's limit");                
            }           
        }
        public Student[] GetStudens()
        {
            return _students;
        }
    }
}
